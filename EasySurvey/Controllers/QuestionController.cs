using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class QuestionController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public List<Question> GetQuestions(long SurveyID)
        {
            List<Question> Questions;
            Questions = new List<Question>(from surveyDefinition in DatabaseModel.SurveyDefinition
                                           join question in DatabaseModel.Question on surveyDefinition.QuestionID equals question.QuestionID
                                           where surveyDefinition.SurveyID == SurveyID
                                           select question);

            return Questions;
        }

        public void Add(ref Question question, long SurveyID)
        {
            DatabaseModel.Question.Add(question);
            DatabaseModel.SaveChanges();

            SurveyDefinitionController surveyDefinitionController = new SurveyDefinitionController();

            surveyDefinitionController.AddRelation(SurveyID, question.QuestionID);
        }

        public void Delete(long QuestionID)
        {
            Question QuestionToDelete = (from question in DatabaseModel.Question where question.QuestionID == QuestionID select question).First();



        }
    }
}
