using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class SurveyDefinitionController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public void AddRelation(long SurveyID, long QuestionID)
        {
            DatabaseModel.SurveyDefinition.Add(new SurveyDefinition() { SurveyID = SurveyID, QuestionID = QuestionID });
            DatabaseModel.SaveChanges();
        }

        public SurveyDefinition GetRelation(long SurveyID, long QuestionID)
        {
            return (from surveyDefinition in DatabaseModel.SurveyDefinition where surveyDefinition.SurveyID == SurveyID && surveyDefinition.QuestionID == QuestionID select surveyDefinition).First();
        }

        public void DeleteRelation(long SurveyID, long QuestionID)
        {
            SurveyDefinition surveyDefinitionToDelete = GetRelation(SurveyID, QuestionID);
            DeleteRelation(surveyDefinitionToDelete);
        }

        public void DeleteRelation(SurveyDefinition surveyDefinition)
        {
            DatabaseModel.SurveyDefinition.Remove(surveyDefinition);
            DatabaseModel.SaveChanges();
        }
    }
}
