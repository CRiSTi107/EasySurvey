using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class QuestionController : BaseController
    {
        public QuestionController()
            : base()
        {
        }

        public QuestionController(Database DBEntity)
            : base(DBEntity)
        {
        }

        public List<Question> GetQuestionsForSurvey(long SurveyID)
        {
            List<Question> Questions;
            Questions = new List<Question>(from surveyDefinition in DatabaseModel.SurveyDefinition
                                           join question in DatabaseModel.Question on surveyDefinition.QuestionID equals question.QuestionID
                                           where surveyDefinition.SurveyID == SurveyID
                                           select question);

            return Questions;
        }

        public List<Question> GetQuestionsForAttitude(long AttitudeID)
        {
            List<Question> Questions = new List<Question>();
            List<AttitudeDefinition> AttitudeDefinitionQuestions;

            AttitudeDefinitionQuestions = new List<AttitudeDefinition>(from attitudeDefinition in DatabaseModel.AttitudeDefinition
                                                                       where attitudeDefinition.AttitudeID == AttitudeID
                                                                       select attitudeDefinition);

            foreach (AttitudeDefinition attitudeDefinition in AttitudeDefinitionQuestions)
            {
                Question currentQuestion = Get(attitudeDefinition.QuestionID);
                Questions.Add(currentQuestion);
            }

            return Questions;
        }

        public List<Question> GetAll()
        {
            return (from question in DatabaseModel.Question select question).ToList();
        }

        public Question Get(long QuestionID)
        {
            return (from question in DatabaseModel.Question where question.QuestionID == QuestionID select question).First();
        }

        public bool Exists(string QuestionName)
        {
            return (from question in DatabaseModel.Question where question.Question1 == QuestionName select question).Count() == 0 ? false : true;
        }

        public void Add(ref Question question, long SurveyID)
        {
            DatabaseModel.Question.Add(question);
            DatabaseModel.SaveChanges();

            using (SurveyDefinitionController surveyDefinitionController = new SurveyDefinitionController(DatabaseModel))
                surveyDefinitionController.AddRelation(SurveyID, question.QuestionID);
        }

        public void Delete(long QuestionID, long SurveyID)
        {
            Question QuestionToDelete = (from question in DatabaseModel.Question where question.QuestionID == QuestionID select question).First();

            using (SurveyDefinitionController surveyDefinitionController = new SurveyDefinitionController(DatabaseModel))
                surveyDefinitionController.DeleteRelation(SurveyID, QuestionID);

            DatabaseModel.Question.Remove(QuestionToDelete);
            DatabaseModel.SaveChanges();
        }

        public void DeleteAll(long SurveyID)
        {
            using (AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController(DatabaseModel))
            {
                List<Question> Questions = GetQuestionsForSurvey(SurveyID);

                foreach (Question question in Questions)
                {
                    Delete(question.QuestionID, SurveyID);
                    attitudeDefinitionController.Delete(question.QuestionID);
                }
            }
        }

        public void Update(long QuestionID, string NewQuestionName)
        {
            DatabaseModel.Question.Where(item => item.QuestionID == QuestionID).ToList().ForEach(item => item.Question1 = NewQuestionName);
            DatabaseModel.SaveChanges();
        }
    }
}
