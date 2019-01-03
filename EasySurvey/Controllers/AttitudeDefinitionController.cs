using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class AttitudeDefinitionController
    {
        private Database DatabaseModel;

        public AttitudeDefinitionController()
        {
            DatabaseModel = new Database();
        }

        public AttitudeDefinitionController(Database DBEntity)
        {
            DatabaseModel = DBEntity;
        }

        public AttitudeDefinition GetRelation(long AttitudeID, long QuestionID)
        {
            return (from attitudeDefinition in DatabaseModel.AttitudeDefinition
                    where attitudeDefinition.AttitudeID == AttitudeID && attitudeDefinition.QuestionID == QuestionID
                    select attitudeDefinition).First();
        }

        public bool AddRelation(long AttitudeID, long QuestionID)
        {
            if (!Exists(AttitudeID, QuestionID))
            {
                DatabaseModel.AttitudeDefinition.Add(new AttitudeDefinition() { AttitudeID = AttitudeID, QuestionID = QuestionID });
                DatabaseModel.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Exists(long AttitudeID, long QuestionID)
        {
            return (from attitudeDefinition in DatabaseModel.AttitudeDefinition where attitudeDefinition.AttitudeID == AttitudeID && attitudeDefinition.QuestionID == QuestionID select attitudeDefinition).ToList().Count == 0 ? false : true;
        }

        public List<AttitudeDefinition> GetRelation(long AttitudeID)
        {
            return new List<AttitudeDefinition>(from attitudeDefinition in DatabaseModel.AttitudeDefinition
                                                where attitudeDefinition.AttitudeID == AttitudeID
                                                select attitudeDefinition);
        }

        public void Update(long AttitudeID, long QuestionID, long NewQuestionID)
        {
            DatabaseModel.AttitudeDefinition.Where(item => item.AttitudeID == AttitudeID && item.QuestionID == QuestionID).ToList().ForEach(item => item.QuestionID = NewQuestionID);
            DatabaseModel.SaveChanges();
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

        public void Delete(long QuestionID, long AttitudeID)
        {
            AttitudeDefinition attitudeDefinitionToDelete = GetRelation(AttitudeID, QuestionID);
            Delete(attitudeDefinitionToDelete);
        }

        /// <summary>
        /// Use with caution! This deletes all Question from every Attitude Definition.
        /// </summary>
        /// <param name="QuestionID">Question ID to be deleted.</param>
        public void Delete(long QuestionID)
        {
            List<AttitudeDefinition> attitudeDefinitionsToDelete;
            attitudeDefinitionsToDelete = (from attitudeDefinition in DatabaseModel.AttitudeDefinition where attitudeDefinition.QuestionID == QuestionID select attitudeDefinition).ToList();

            foreach (AttitudeDefinition attitudeDefinition in attitudeDefinitionsToDelete)
                Delete(attitudeDefinition);

            DatabaseModel.SaveChanges();
        }
    }
}
