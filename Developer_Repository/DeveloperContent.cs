using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{

    public class DeveloperList
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DeveloperID { get; set; }

        public string PluralSight { get; set; }

        public DeveloperList() { }

        public DeveloperList(string firstName, string lastName, int developerID, string pluralSight)
        {
            FirstName = firstName;
            LastName = lastName;
            DeveloperID = developerID;
            PluralSight = pluralSight;

        }

    } // End of DeveloperList Class
} // End of namespace
