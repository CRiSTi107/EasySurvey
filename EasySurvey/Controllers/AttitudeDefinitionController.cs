﻿using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class AttitudeDefinitionController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public AttitudeDefinition GetRelation(long AttitudeID, long QuestionID)
        {
            return (from attitudeDefinition in DatabaseModel.AttitudeDefinition
                    where attitudeDefinition.AttitudeID == AttitudeID && attitudeDefinition.QuestionID == QuestionID
                    select attitudeDefinition).First();
        }

        public List<AttitudeDefinition> GetRelation(long AttitudeID)
        {
            return new List<AttitudeDefinition>(from attitudeDefinition in DatabaseModel.AttitudeDefinition
                                                where attitudeDefinition.AttitudeID == AttitudeID
                                                select attitudeDefinition);
        }

        public void Delete(AttitudeDefinition attitudeDefinition)
        {
            DatabaseModel.AttitudeDefinition.Remove(attitudeDefinition);
            DatabaseModel.SaveChanges();
        }

        public void DeleteAll(long AttitudeID)
        {
            List<AttitudeDefinition> attitudeDefinitionsToDelete = GetRelation(AttitudeID);

            foreach (AttitudeDefinition attitudeDefinition in attitudeDefinitionsToDelete)
            {
                Delete(attitudeDefinition);
            }
        }
    }
}