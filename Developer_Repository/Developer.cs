using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{

    public class Developer
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DeveloperID { get; set; }

        public string PluralSight { get; set; }

        public string DeveloperTeamID{ get; set; }

        public Developer() { }

        public Developer(string firstName, string lastName, string developerID, string pluralSight, string developerTeamID)
        {
            FirstName = firstName;
            LastName = lastName;
            DeveloperID = developerID;
            PluralSight = pluralSight;
            DeveloperTeamID = developerTeamID;

        }

    } // End of DeveloperList Class
} // End of namespace
