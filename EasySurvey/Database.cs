using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EasySurvey
{
    public class Database : DatabaseEntity
    {
        public Database()
            : base()
        {
            CreateDirectories();
        }

        public Database(string DatabasePath)
            : base(GetConnectionString(DatabasePath))
        {
            CreateDirectories();
        }

        public static string GetConnectionString(string DatabasePath)
        {
            const string QUOT = "\"";
            string DatabaseConnetionString = "metadata=res://*/Models.DatabaseModel.csdl|res://*/Models.DatabaseModel.ssdl|res://*/Models.DatabaseModel.msl;provider=System.Data.SQLite.EF6;provider connection string='data source=" + QUOT + DatabasePath + QUOT + "'";
            return DatabaseConnetionString;
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
                using (DatabaseEntity DBRestore = new DatabaseEntity(GetConnectionString(DatabaseBackupPath)))
                using (DatabaseEntity DBCurrent = new DatabaseEntity())
                    try
                    {


                        DBCurrent.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                // File.Delete(DATABASE_PATH);
                // File.Copy(DatabaseBackupPath, DATABASE_PATH);
            }


        }

        public void Import(string DatabaseImportPath)
        {
            using (Database DB = new Database(DatabaseImportPath))
            {
                //Copy data from Export Database to Current Database.
            }

        }
    }
}
