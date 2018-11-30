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
    }
}
