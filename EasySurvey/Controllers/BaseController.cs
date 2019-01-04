using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class BaseController : IDisposable
    {
        protected Database DatabaseModel;

        public BaseController()
        {
            DatabaseModel = new Database();
        }

        public BaseController(Database DBEntity)
        {
            DatabaseModel = DBEntity;
        }

        public void Dispose()
        {
            DatabaseModel.Close();
            //EDIT DatabaseModel.Dispose();
        }
    }
}
