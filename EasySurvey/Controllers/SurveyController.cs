using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class SurveyController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public List<Survey> GetAll()
        {
            List<Survey> surveys = new List<Survey>();
            surveys = new List<Survey>(from survey in DatabaseModel.Survey select survey);
            return surveys;
        }

        public IEnumerable<Survey> Search(List<Survey> all_surveys, string search_query, ref bool search, bool permissive = true)
        {
            IEnumerable<Survey> all_result = new List<Survey>();
            IEnumerable<Survey> result_temp = new List<Survey>();

            search = (search_query == String.Empty) ? false : true;

            if (!search) return all_surveys;
            if (permissive) search_query = search_query.ToLower();

            string[] search_query_array = search_query.Split(' ');

            foreach (string search_tag in search_query_array)
            {
                result_temp = null;

                if (search_tag != String.Empty && search_tag != " " && search_tag.Trim() != String.Empty)
                    if (permissive)
                        result_temp = from survey in all_surveys
                                      where survey.SurveyName.ToLower().Contains(search_tag)
                                      select survey;
                    else
                        result_temp = from survey in all_surveys
                                      where survey.SurveyName.Contains(search_tag)
                                      select survey;

                if (result_temp != null)
                {
                    AddManyTo(ref all_result, result_temp);
                }

            }

            return all_result;
        }

        private void AddManyTo(ref IEnumerable<Survey> ListToAddTo, IEnumerable<Survey> ListToBeAdded)
        {
            List<Survey> temp = new List<Survey>(ListToAddTo);

            foreach (Survey survey in ListToBeAdded)
            {
                if (!ListToAddTo.Contains(survey))
                    temp.Add(survey);
            }

            ListToAddTo = temp;
        }

        public Survey Get(long SurveyID)
        {
            return (from survey in DatabaseModel.Survey where survey.SurveyID == SurveyID select survey).First();
        }

        public Survey GetByQuestion(long QuestionID)
        {
            SurveyDefinition selectedSurveyDefinition = (from surveyDefinition in DatabaseModel.SurveyDefinition
                                                         where surveyDefinition.QuestionID == QuestionID
                                                         select surveyDefinition).First();

            Survey selectedSurvey = (from survey in DatabaseModel.Survey
                                     where survey.SurveyID == selectedSurveyDefinition.SurveyID
                                     select survey).First();

            return selectedSurvey;
        }

        public void Delete(long SurveyID)
        {
            Survey surveyToDelete = (from survey in DatabaseModel.Survey where survey.SurveyID == SurveyID select survey).First();

            QuestionController questionController = new QuestionController();
            questionController.DeleteAll(SurveyID);

            DatabaseModel.Survey.Remove(surveyToDelete);
            DatabaseModel.SaveChanges();
        }

        public void Add(ref Survey NewSurvey)
        {
            DatabaseModel.Survey.Add(NewSurvey);
            DatabaseModel.SaveChanges();
        }

        public void UpdateSurveyName(long SurveyID, string NewSurveyName)
        {
            DatabaseModel.Survey.Where(item => item.SurveyID == SurveyID).ToList().ForEach(item => item.SurveyName = NewSurveyName);
            DatabaseModel.SaveChanges();
        }

    }
}
