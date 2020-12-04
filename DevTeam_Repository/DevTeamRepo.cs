using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class DevTeamRepo
    {

        private List<TeamList> _teamList = new List<TeamList>();

        // Create

        public void AddNewTeam(TeamList content)
        {

            _teamList.Add(content);

        }

        public List<TeamList> GetTeamList()
        {

            return _teamList;

        }



    }

   
}
