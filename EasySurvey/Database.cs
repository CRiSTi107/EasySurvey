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
        public const string DATABASE_NAME = "database";
        public const string DATABASE_EXTENSION = "db";
        public const string DATABASE_PATH = DATABASE_NAME + "." + DATABASE_EXTENSION;
        public const string DATABASE_BACKUP_EXTENSION = "bak";

        public string Backup()
        {
            if (!Directory.Exists(BACKUP_FOLDER))
                Directory.CreateDirectory(BACKUP_FOLDER);

            string CurrentTime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss.f");
            string DatabaseBackupName = DATABASE_NAME + "_" + CurrentTime + "." + DATABASE_EXTENSION + "." + DATABASE_BACKUP_EXTENSION;

            if (File.Exists(BACKUP_FOLDER + DatabaseBackupName))
                File.Delete(BACKUP_FOLDER + DatabaseBackupName);

            File.Copy(DATABASE_PATH, BACKUP_FOLDER + DatabaseBackupName);

            return DatabaseBackupName;
        }

        public void Restore(string DatabaseBackupPath)
        {
            Backup();

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
    }
}
