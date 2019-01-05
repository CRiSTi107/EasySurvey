using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class BaseController : IDisposable
    {
        protected Database DatabaseModel;
        protected string DatabasePath;

        public BaseController()
        {
            DatabaseModel = new Database();
            DatabasePath = Database.GetDatabasePath(DatabaseModel.Database.Connection.ConnectionString);
        }

        public BaseController(string DatabasePath)
        {
            DatabaseModel = new Database(DatabasePath);
            this.DatabasePath = DatabasePath;
        }

        public void Dispose()
        {
            DatabaseModel.Close();
            //EDIT DatabaseModel.Dispose();
        }
    }
}
