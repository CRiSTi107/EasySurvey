using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class ResultController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public void Add(Result NewResult)
        {
            DatabaseModel.Result.Add(NewResult);
            DatabaseModel.SaveChanges();
        }
    }
}
