using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{
    public class DeveloperRepo
    {


        private List<DeveloperList> _listOfDevelopers = new List<DeveloperList>();

        // Create

        public void AddDeveloperToList(DeveloperList content)
        {
           
            _listOfDevelopers.Add(content);
        
        }

        // Read

        public List<DeveloperList> GetDeveloperList()
        {

            return _listOfDevelopers;
        
        }


        // Update


        public bool UpdateListOfDevelopers(int developerID, DeveloperList newContent)
        {

            // Find content
            DeveloperList oldContent = GetDeveloperByID(developerID);



            // Update content
            if (oldContent != null)
            {
                oldContent.FirstName = newContent.FirstName;
                oldContent.LastName = newContent.LastName;
                oldContent.DeveloperID = newContent.DeveloperID;
                oldContent.PluralSight = newContent.PluralSight;
                return true;

            } else {
                
                return false;
            }


        }


        // Delete
        public bool RemoveDeveloperFromList (int developerID) 
        {

            var developerInfo = GetDeveloperByID(developerID);

            if (developerID == null) 
            {
                return false;
            
            }

            int initialCount = _listOfDevelopers.Count;

            _listOfDevelopers.Remove(developerInfo);

            if (initialCount > _listOfDevelopers.Count) 
            {
                return true;

            } else {
            
                return false;
            }


        }

        // Helper Methods

        public DeveloperList GetDeveloperByID(int developerID)
        {
            foreach (DeveloperList content in _listOfDevelopers)
            {
                if (content.DeveloperID == developerID)
                {
                    return content;
                }
            }
            return null;
        }

  
    }  // END OF DeveloperRepo CLass
}  // End of name space
