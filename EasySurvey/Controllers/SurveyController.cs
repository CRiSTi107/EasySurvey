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

        public List<Survey> GetSurveys()
        {
            List<Survey> surveys = new List<Survey>();
            surveys = new List<Survey>(from survey in DatabaseModel.Survey select survey);
            return surveys;
        }
    }
}
