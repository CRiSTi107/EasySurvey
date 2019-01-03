using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class ResultController
    {
        private Database DatabaseModel;

        public ResultController()
        {
            DatabaseModel = new Database();
        }

        public ResultController(Database DBEntity)
        {
            DatabaseModel = DBEntity;
        }

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
            Delete(ResultToDelete);
        }

        public void Delete(Result ResultToDelete)
        {
            //Delete Result Definitions first
            ResultDefinitionController resultDefinitionController = new ResultDefinitionController();
            resultDefinitionController.Delete(ResultToDelete.ResultID);

            DatabaseModel.Result.Remove(ResultToDelete);
            DatabaseModel.SaveChanges();
        }

        /// <summary>
        /// Delete all Results for a user.
        /// Use with caution.
        /// </summary>
        /// <param name="UserID"></param>
        public void DeleteAll(long UserID)
        {
            List<Result> ResultsToDelete = GetForUser(UserID);
            foreach (Result ResultToDelete in ResultsToDelete)
                Delete(ResultToDelete);
        }
    }
}
