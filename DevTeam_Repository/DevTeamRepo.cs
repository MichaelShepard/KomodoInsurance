using Developer_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Repository
{
    public class DevTeamRepo
    {

        private List<DevTeam> _teamList = new List<DevTeam>();

        private DeveloperRepo _devRepo = new DeveloperRepo();


        // Create

        public void AddNewTeam(DevTeam content)
        {

            _teamList.Add(content);

        }

        public List<DevTeam> GetTeamList()
        {

            return _teamList;

        }

        // Delete 

        public bool DeleteTeam(string teamName)
        {
            var teamInfo = GetTeamByName(teamName);

            if (teamName == null)
            {
                return false;

            }

            int initialCount = _teamList.Count;

            _teamList.Remove(teamInfo);

            if (initialCount > _teamList.Count)
            {
                return true;

            }
            else
            {

                return false;
            }
        }



        // Helper Methods

        public DevTeam GetTeamByName(string teamName)
        {
            foreach (DevTeam content in _teamList)
            {
                if (content.TeamName == teamName)
                {
                    return content;
                }
            }
            return null;
        }




    } // End of Class
} // End of name space
