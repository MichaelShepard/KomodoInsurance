using Developer_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class DevTeam
    {

        public string TeamName { get; set; }

        public string TeamID { get; set; }


        public DevTeam() { }

        public DevTeam(string teamName, string teamID)
        {
            TeamName = teamName;
            TeamID = teamID;

        }
    }
}
