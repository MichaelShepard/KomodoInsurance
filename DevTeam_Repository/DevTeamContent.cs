using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class TeamList
    {

        public string TeamName { get; set; }

        public int TeamID { get; set; }


        public TeamList() { }

        public TeamList(string teamName, int teamID)
        {
            TeamName = teamName;
            TeamID = teamID;

        }
    }
}
