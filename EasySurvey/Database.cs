using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EasySurvey
{
    public class Database // : DatabaseEntity
    {
        public Database()
        {
            if (!Directory.Exists(BACKUP_FOLDER)) Directory.CreateDirectory(BACKUP_FOLDER);
            if (!Directory.Exists(BACKUP_AUTO_FOLDER)) Directory.CreateDirectory(BACKUP_AUTO_FOLDER);
            if (!Directory.Exists(EXPORT_FOLDER)) Directory.CreateDirectory(EXPORT_FOLDER);
        }

        // public Database()
        //     : base()
        // {
        //     Path = "database.db";
        // }
        // 
        // private string _Path;
        // public string Path
        // {
        //     get
        //     {
        //         return _Path;
        //     }
        // 
        //     private set
        //     {
        //         _Path = value;
        //     }
        // }
        // 
        // public override int SaveChanges()
        // {
        //     return base.SaveChanges();
        // }

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
            Backup(BackupReason.Automatic);

            if (File.Exists(DATABASE_PATH))
            {
                DatabaseEntity db = new DatabaseEntity();

                // TODO: Fix here bug.
                bool isDone = false;
                while (!isDone)
                    try
                    {
                        db.Close();
                        File.Delete(DATABASE_PATH);
                        isDone = true;
                    }
                    catch { }

            }

            File.Copy(DatabaseBackupPath, DATABASE_PATH);
        }

        public void Import(string DatabaseExportPath)
        {
            // 
        }
    }
}
