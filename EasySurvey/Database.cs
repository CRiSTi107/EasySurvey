using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using EasySurvey.Controllers;

namespace EasySurvey
{
    public class Database : DatabaseEntity
    {
        public Database()
            : base()
        {
        }

        public Database(string DatabasePath)
            : base(GetConnectionString(DatabasePath))
        {
        }

        public static string GetConnectionString(string DatabasePath)
        {
            const string QUOT = "\"";
            string DatabaseConnetionString = "metadata=res://*/Models.DatabaseModel.csdl|res://*/Models.DatabaseModel.ssdl|res://*/Models.DatabaseModel.msl;provider=System.Data.SQLite.EF6;provider connection string='data source=" + QUOT + DatabasePath + QUOT + "'";
            return DatabaseConnetionString;
        }

        public static string GetDatabasePath(string ConnectionString)
        {
            return ConnectionString.Split('"')[1];
        }

        private void CreateDirectories()
        {
            if (!Directory.Exists(BACKUP_FOLDER)) Directory.CreateDirectory(BACKUP_FOLDER);
            if (!Directory.Exists(BACKUP_AUTO_FOLDER)) Directory.CreateDirectory(BACKUP_AUTO_FOLDER);
            if (!Directory.Exists(EXPORT_FOLDER)) Directory.CreateDirectory(EXPORT_FOLDER);
        }

        public const string BACKUP_FOLDER = "backup\\";
        public const string BACKUP_AUTO_FOLDER = "backup\\auto\\";
        public const string EXPORT_FOLDER = "export\\";

        public const string DATABASE_NAME = "database";
        public const string DATABASE_EXTENSION = "db";

        public const string DATABASE_PATH = DATABASE_NAME + "." + DATABASE_EXTENSION;

        public const string DATABASE_BACKUP_EXTENSION = "bak";
        public const string DATABASE_EXPORT_EXTENSION = "dat";

        public enum BackupReason : int
        {
            Automatic = 1,
            User = 2
        }

        private void Save(string DirectoryPath, string FileName)
        {
            CreateDirectories();

            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);

            if (File.Exists(DirectoryPath + FileName))
                File.Delete(DirectoryPath + FileName);

            File.Copy(DATABASE_PATH, DirectoryPath + FileName);
        }

        public string Backup(BackupReason Reason)
        {
            string CurrentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss.f");
            string DatabaseBackupName = DATABASE_NAME + "_" + CurrentTime + "." + DATABASE_EXTENSION + "." + DATABASE_BACKUP_EXTENSION;
            string BackupFolder = String.Empty;

            if (Reason == BackupReason.Automatic)
                BackupFolder = BACKUP_AUTO_FOLDER;
            else if (Reason == BackupReason.User)
                BackupFolder = BACKUP_FOLDER;

            this.Save(BackupFolder, DatabaseBackupName);
            return DatabaseBackupName;
        }

        public string Export()
        {
            string CurrentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss.f");
            string DatabaseExportName = DATABASE_NAME + "_" + CurrentTime + "." + DATABASE_EXTENSION + "." + DATABASE_EXPORT_EXTENSION;
            this.Save(EXPORT_FOLDER, DatabaseExportName);
            return DatabaseExportName;
        }

        public void Restore(string DatabaseBackupPath)
        {
            if (File.Exists(DATABASE_PATH))
            {
                // using (DatabaseEntity DBRestore = new DatabaseEntity(GetConnectionString(DatabaseBackupPath)))
                // using (DatabaseEntity DBCurrent = new DatabaseEntity())
                //     try
                //     {
                //         DBCurrent.User.ToList().ForEach(item => DBCurrent.User.Remove(item));
                //         DBCurrent.UserRole.ToList().ForEach(item => DBCurrent.UserRole.Remove(item));
                // 
                //         DBCurrent.SaveChanges();
                // 
                //         var users = DBRestore.User.ToList();
                // 
                //         DBRestore.User.ToList().ForEach(item => DBCurrent.User.Add(item));
                //         DBRestore.UserRole.ToList().ForEach(item => DBCurrent.UserRole.Add(item));
                // 
                //         DBCurrent.SaveChanges();
                //     }
                //     catch (Exception ex)
                //     {
                //         throw ex;
                //     }
                // File.Delete(DATABASE_PATH);
                // File.Copy(DatabaseBackupPath, DATABASE_PATH);
            }
            base.Dispose();

            //File.Delete(DATABASE_PATH);
            File.Copy(DatabaseBackupPath, DATABASE_PATH, true);

        }

        public void Import(string DatabaseImportPath)
        {
            // Copy data from Export Database to Current Database.
            using (Database DBRestore = new Database(DatabaseImportPath))
            {
                List<UserModelDataTransferObject> RestoreUsers;
                List<UserModelDataTransferObject> CurrentUsers;

                using (UserController userController = new UserController(DatabaseImportPath))
                    RestoreUsers = userController.GetUsers().OrderBy(u => u.UserID).ToList();

                using (UserController userController = new UserController())
                    CurrentUsers = userController.GetUsers().OrderBy(u => u.UserID).ToList();

                // Checking if there are same users.
                if (CurrentUsers.Count != RestoreUsers.Count)
                    throw new Exception("Selected database does not have the same Users.");

                for (int UserIndex = 0; UserIndex <= RestoreUsers.Count - 1; ++UserIndex)
                    if (CurrentUsers[UserIndex] != RestoreUsers[UserIndex])
                        throw new Exception("Selected database does not have the same Users.");

                // Check if there are the same Questions
                List<Question> RestoreQuestions, CurrentQuestions;
                using (QuestionController questionControllerRestore = new QuestionController(DatabaseImportPath))
                    RestoreQuestions = questionControllerRestore.GetAll();
                using (QuestionController questionControllerCurrent = new QuestionController())
                    CurrentQuestions = questionControllerCurrent.GetAll();
                if (CurrentQuestions.Count != RestoreQuestions.Count)
                    throw new Exception("Selected database does not have the same Questions.");
                foreach (Question CurrentQuestion in CurrentQuestions)
                    if (!RestoreQuestions.Any(q => q.QuestionID == CurrentQuestion.QuestionID &&
                                                  q.Question1 == CurrentQuestion.Question1))
                        throw new Exception("Selected database does not have the same Questions.");

                // TODO: Check if Surveys & Attitudes are the same

                // Actually import new data from Result Table
                using (ResultController resultControllerRestore = new ResultController(DatabaseImportPath))
                using (ResultController resultControllerCurrent = new ResultController())
                {
                    List<Result> RestoreResults = resultControllerRestore.Get();
                    List<Result> CurrentResults = resultControllerCurrent.Get();

                    foreach (Result RestoreResult in RestoreResults)
                        if (!CurrentResults.Any(r => r.ResultID == RestoreResult.ResultID &&
                                                     r.SurveyID == RestoreResult.SurveyID &&
                                                     r.Date == RestoreResult.Date &&
                                                     r.UserID == RestoreResult.UserID))
                        {
                            // Add to result table
                            long OldResultID = RestoreResult.ResultID;
                            resultControllerCurrent.Add(RestoreResult); // ID may change during adding.
                            long NewResultID = RestoreResult.ResultID;

                            // Get all Result definitions
                            using (ResultDefinitionController resultDefinitionControllerRestore = new ResultDefinitionController(DatabaseImportPath))
                            using (ResultDefinitionController resultDefinitionControllerCurrent = new ResultDefinitionController())
                            {
                                List<ResultDefinition> RestoreResultDefinitions = resultDefinitionControllerRestore.Get(OldResultID);
                                RestoreResultDefinitions.ForEach(rd => rd.ResultID = NewResultID); // Update with new ResultID
                                resultDefinitionControllerCurrent.Add(RestoreResultDefinitions);
                            }
                        }
                }


            }

        }
    }
}
