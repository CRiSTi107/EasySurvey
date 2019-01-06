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
            base.Dispose();
            File.Copy(DatabaseBackupPath, DATABASE_PATH, true);
        }

        public long Import(string DatabaseImportPath)
        {
            // Copy data from Export Database to Current Database.
            using (Database DBRestore = new Database(DatabaseImportPath))
            {
                // Checking if there are same Users.
                List<UserModelDataTransferObject> RestoreUsers, CurrentUsers;
                using (UserController UserController = new UserController(DatabaseImportPath))
                    RestoreUsers = UserController.GetUsers().OrderBy(u => u.UserID).ToList();
                using (UserController UserController = new UserController())
                    CurrentUsers = UserController.GetUsers().OrderBy(u => u.UserID).ToList();
                if (CurrentUsers.Count != RestoreUsers.Count)
                    throw new Exception("Selected database does not have the same Users.");
                for (int UserIndex = 0; UserIndex <= RestoreUsers.Count - 1; ++UserIndex)
                    if (CurrentUsers[UserIndex] != RestoreUsers[UserIndex])
                        throw new Exception("Selected database does not have the same Users.");

                // Check if there are the same Questions
                List<Question> RestoreQuestions, CurrentQuestions;
                using (QuestionController QuestionControllerRestore = new QuestionController(DatabaseImportPath))
                    RestoreQuestions = QuestionControllerRestore.GetAll();
                using (QuestionController QuestionControllerCurrent = new QuestionController())
                    CurrentQuestions = QuestionControllerCurrent.GetAll();
                if (CurrentQuestions.Count != RestoreQuestions.Count)
                    throw new Exception("Selected database does not have the same Questions.");
                foreach (Question CurrentQuestion in CurrentQuestions)
                    if (!RestoreQuestions.Any(q => q.QuestionID == CurrentQuestion.QuestionID &&
                                                   q.Question1 == CurrentQuestion.Question1))
                        throw new Exception("Selected database does not have the same Questions.");

                // Check if there are the same Surveys
                List<Survey> RestoreSurveys, CurrentSurveys;
                using (SurveyController SurveyControllerRestore = new SurveyController(DatabaseImportPath))
                    RestoreSurveys = SurveyControllerRestore.GetAll();
                using (SurveyController SurveyControllerCurrent = new SurveyController())
                    CurrentSurveys = SurveyControllerCurrent.GetAll();
                if (CurrentSurveys.Count != RestoreSurveys.Count)
                    throw new Exception("Selected database does not have the same Surveys.");
                foreach (Survey CurrentSurvey in CurrentSurveys)
                    if (!RestoreSurveys.Any(s => s.SurveyID == CurrentSurvey.SurveyID &&
                                                 s.SurveyName == CurrentSurvey.SurveyName))
                        throw new Exception("Selected database does not have the same Surveys.");

                // Check if there are the same Survey Definitions
                List<SurveyDefinition> RestoreSurveyDefinitions, CurrentSurveyDefinitions;
                using (SurveyDefinitionController AttitudeDefinitionControllerRestore = new SurveyDefinitionController(DatabaseImportPath))
                    RestoreSurveyDefinitions = AttitudeDefinitionControllerRestore.Get();
                using (SurveyDefinitionController AttitudeDefinitionControllerCurrent = new SurveyDefinitionController())
                    CurrentSurveyDefinitions = AttitudeDefinitionControllerCurrent.Get();
                if (CurrentSurveyDefinitions.Count != RestoreSurveyDefinitions.Count)
                    throw new Exception("Selected database does not have the same Survey Definitions.");
                foreach (SurveyDefinition CurrentSurveyDefinition in CurrentSurveyDefinitions)
                    if (!RestoreSurveyDefinitions.Any(sd => sd.SurveyDefinitionID == CurrentSurveyDefinition.SurveyDefinitionID &&
                                                            sd.QuestionID == CurrentSurveyDefinition.QuestionID &&
                                                            sd.SurveyID == CurrentSurveyDefinition.SurveyID))
                        throw new Exception("Selected database does not have the same Survey Definitions.");

                // Check if there are the same Attitudes
                List<Attitude> RestoreAttitudes, CurrentAttitudes;
                using (AttitudeController AttitudeControllerRestore = new AttitudeController(DatabaseImportPath))
                    RestoreAttitudes = AttitudeControllerRestore.GetAttitudes();
                using (AttitudeController AttitudeControllerCurrent = new AttitudeController())
                    CurrentAttitudes = AttitudeControllerCurrent.GetAttitudes();
                if (CurrentAttitudes.Count != RestoreAttitudes.Count)
                    throw new Exception("Selected database does not have the same Attitudes.");
                foreach (Attitude CurrentAttitude in CurrentAttitudes)
                    if (!RestoreAttitudes.Any(a => a.AttitudeID == CurrentAttitude.AttitudeID &&
                                                 a.AttitudeName == CurrentAttitude.AttitudeName))
                        throw new Exception("Selected database does not have the same Attitudes.");

                // Check if there are the same Attitudes Definitions
                List<AttitudeDefinition> RestoreAttitudeDefinitions, CurrentAttitudeDefinitions;
                using (AttitudeDefinitionController AttitudeDefinitionControllerRestore = new AttitudeDefinitionController(DatabaseImportPath))
                    RestoreAttitudeDefinitions = AttitudeDefinitionControllerRestore.Get();
                using (AttitudeDefinitionController AttitudeDefinitionControllerCurrent = new AttitudeDefinitionController())
                    CurrentAttitudeDefinitions = AttitudeDefinitionControllerCurrent.Get();
                if (CurrentAttitudeDefinitions.Count != RestoreAttitudeDefinitions.Count)
                    throw new Exception("Selected database does not have the same Attitude Definitions.");
                foreach (AttitudeDefinition CurrentAttitudeDefinition in CurrentAttitudeDefinitions)
                    if (!RestoreAttitudeDefinitions.Any(ad => ad.AttitudeDefinitionID == CurrentAttitudeDefinition.AttitudeDefinitionID &&
                                                              ad.AttitudeID == CurrentAttitudeDefinition.AttitudeID &&
                                                              ad.QuestionID == CurrentAttitudeDefinition.QuestionID))
                        throw new Exception("Selected database does not have the same Attitude Definitions.");


                // Actually import new data from Result Table
                long ImportedResultCount = 0;
                using (ResultController resultControllerRestore = new ResultController(DatabaseImportPath))
                using (ResultController resultControllerCurrent = new ResultController())
                {
                    List<Result> RestoreResults = resultControllerRestore.Get();
                    List<Result> CurrentResults = resultControllerCurrent.Get();

                    foreach (Result RestoreResult in RestoreResults)
                        if (!CurrentResults.Any(r => r.SurveyID == RestoreResult.SurveyID &&
                                                     r.Date == RestoreResult.Date &&
                                                     r.UserID == RestoreResult.UserID))
                        {
                            // Add to result table
                            long OldResultID = RestoreResult.ResultID;
                            resultControllerCurrent.Add(RestoreResult); // ID may change during adding.
                            long NewResultID = RestoreResult.ResultID;
                            ++ImportedResultCount;

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
                return ImportedResultCount;

            }

        }
    }
}
