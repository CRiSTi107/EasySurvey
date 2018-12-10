using EasySurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySurvey.Controllers
{
    public class AttitudeController
    {
        private DatabaseEntity DatabaseModel = new DatabaseEntity();

        public List<Attitude> GetAttitudes()
        {
            List<Attitude> attitudes = new List<Attitude>();
            attitudes = new List<Attitude>(from attitude in DatabaseModel.Attitude select attitude);
            return attitudes;
        }

        public IEnumerable<Attitude> Search(List<Attitude> all_attitudes, string search_query, ref bool search, bool permissive = true)
        {
            IEnumerable<Attitude> all_result = new List<Attitude>();
            IEnumerable<Attitude> result_temp = new List<Attitude>();

            search = (search_query == String.Empty) ? false : true;

            if (!search) return all_attitudes;
            if (permissive) search_query = search_query.ToLower();

            string[] search_query_array = search_query.Split(' ');

            foreach (string search_tag in search_query_array)
            {
                result_temp = null;

                if (search_tag != String.Empty && search_tag != " " && search_tag.Trim() != String.Empty)
                    if (permissive)
                        result_temp = from attitude in all_attitudes
                                      where attitude.AttitudeName.ToLower().Contains(search_tag)
                                      select attitude;
                    else
                        result_temp = from attitude in all_attitudes
                                      where attitude.AttitudeName.Contains(search_tag)
                                      select attitude;

                if (result_temp != null)
                {
                    AddManyTo(ref all_result, result_temp);
                }

            }

            return all_result;
        }

        private void AddManyTo(ref IEnumerable<Attitude> ListToAddTo, IEnumerable<Attitude> ListToBeAdded)
        {
            List<Attitude> temp = new List<Attitude>(ListToAddTo);

            foreach (Attitude attitude in ListToBeAdded)
            {
                if (!ListToAddTo.Contains(attitude))
                    temp.Add(attitude);
            }

            ListToAddTo = temp;
        }

        public void Add(ref Attitude NewAttitude)
        {
            DatabaseModel.Attitude.Add(NewAttitude);
            DatabaseModel.SaveChanges();
        }

        public Attitude GetAttitude(long AttitudeID)
        {
            return (from attitude in DatabaseModel.Attitude where attitude.AttitudeID == AttitudeID select attitude).First();
        }

        public void Delete(long AttitudeID)
        {
            Attitude attitudeToDelete = (from attitude in DatabaseModel.Attitude where attitude.AttitudeID == AttitudeID select attitude).First();

            //Delete Attitude Definitions
            AttitudeDefinitionController attitudeDefinitionController = new AttitudeDefinitionController();
            attitudeDefinitionController.DeleteAll(AttitudeID);

            DatabaseModel.Attitude.Remove(attitudeToDelete);
            DatabaseModel.SaveChanges();
        }

        public void UpdateAttitudeName(long AttitudeID, string NewAttitudeName)
        {
            DatabaseModel.Attitude.Where(item => item.AttitudeID == AttitudeID).ToList().ForEach(item => item.AttitudeName = NewAttitudeName);
            DatabaseModel.SaveChanges();
        }
    }
}
