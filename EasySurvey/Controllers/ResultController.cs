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

        public List<Result> Get()
        {
            return (from result in DatabaseModel.Result select result).ToList();
        }

        public Result Get(long ResultID)
        {
            return (from result in DatabaseModel.Result where result.ResultID == ResultID select result).First();
        }

        public List<Result> GetForUser(long UserID)
        {
            return (from result in DatabaseModel.Result where result.UserID == UserID select result).ToList();
        }

        public void Add(Result NewResult)
        {
            DatabaseModel.Result.Add(NewResult);
            DatabaseModel.SaveChanges();
        }

        public void Delete(long ResultID)
        {
            Result ResultToDelete = Get(ResultID);

            //Delete Result Definitions first

            ResultDefinitionController resultDefinitionController = new ResultDefinitionController();

            resultDefinitionController.Delete(ResultID);

            DatabaseModel.Result.Remove(ResultToDelete);
            DatabaseModel.SaveChanges();
        }
    }
}
