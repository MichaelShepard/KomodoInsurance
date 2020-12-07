using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{
    public class DeveloperRepo
    {

        private static List<Developer> _listOfDevelopers = new List<Developer>();

        // Create

        public void AddDeveloperToList(Developer content)
        {
           
            _listOfDevelopers.Add(content);
        
        }

        // Read

        public List<Developer> GetDeveloperList()
        {

            return _listOfDevelopers;
        
        }


        // Update


        public bool UpdateListOfDevelopers(string developerID, Developer newContent)
        {

            // Find content
            Developer oldContent = GetDeveloperByID(developerID);



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

        public bool UpdateTeamforDeveloper(string developerID, Developer newContent)
        {


            // Find content
            Developer oldContent = GetDeveloperByID(developerID);



            // Update content
            if (oldContent != null)
            {
                oldContent.FirstName = oldContent.FirstName;
                oldContent.LastName = oldContent.LastName;
                oldContent.DeveloperID = oldContent.DeveloperID;
                oldContent.PluralSight = oldContent.PluralSight;
                oldContent.DeveloperTeamID = newContent.DeveloperTeamID;
                return true;

            }
            else
            {

                return false;
            }


        }

        // Delete
        public bool RemoveDeveloperFromList (string developerID) 
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

        public Developer GetDeveloperByID(string developerID)
        {
            foreach (Developer content in _listOfDevelopers)
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
