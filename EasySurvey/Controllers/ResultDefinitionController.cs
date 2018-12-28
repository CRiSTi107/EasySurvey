using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class ResultDefinitionController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

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
    }
}
