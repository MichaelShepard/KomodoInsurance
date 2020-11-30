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

        public DeveloperList() { }

        public DeveloperList(string firstName, string lastName, int developerID)
        {
            FirstName = firstName;
            LastName = lastName;
            DeveloperID = developerID;

        }

    }
}
