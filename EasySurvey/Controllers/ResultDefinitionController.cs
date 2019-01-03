using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class ResultDefinitionController
    {
        private Database DatabaseModel;

        public ResultDefinitionController()
        {
            DatabaseModel = new Database();
        }

        public ResultDefinitionController(Database DBEntity)
        {
            DatabaseModel = DBEntity;
        }

        public void Add(ResultDefinition resultDefinition)
        {
            DatabaseModel.ResultDefinition.Add(resultDefinition);
            DatabaseModel.SaveChanges();
        }

        public void Add(List<ResultDefinition> resultDefinitionList)
        {
            foreach (ResultDefinition resultDefinition in resultDefinitionList)
                Add(resultDefinition);
        }

        public List<ResultDefinition> Get(long ResultID)
        {
            return (from resultDefinition in DatabaseModel.ResultDefinition where resultDefinition.ResultID == ResultID select resultDefinition).ToList();
        }

        public void Delete(long ResultID)
        {
            List<ResultDefinition> ResultDefinitionsToDelete = Get(ResultID);
            Delete(ResultDefinitionsToDelete);
        }

        public void Delete(List<ResultDefinition> ResultDefinitions)
        {
            foreach (ResultDefinition ResultDefinition in ResultDefinitions)
                DatabaseModel.ResultDefinition.Remove(ResultDefinition);
            DatabaseModel.SaveChanges();
        }
    }
}
