﻿using Developer_Repository;
using DevTeam_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoInsurance_Console
{
    public class DeveloperUI
    {

        private DeveloperRepo _developerList = new DeveloperRepo();
        

        public void Run()
        {
            //SeedDeveloperList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                 Console.WriteLine("Select a menu option: \n" +
                    "1. List of Developers \n" +
                    "2. Find Developer by ID \n" +
                    "3. Create New Developer \n" +
                    "4. Update Existing Developer \n" +
                    "5. Delete Developer \n" +
                    "6. Developers who need a PluralSight license \n" +
                    "7. Go to DevTeams Console \n" +
                    "8. Exit");

                //Get the users input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Display list of all developers
                        DisplayDeveloperAll();
                        break;
                    case "2":
                        // View developer using the ID
                        DisplayDeveloperByID();
                        break;
                    case "3":
                        // View content by title
                        CreateNewDeveloper();
                        break;
                    case "4":
                        // Update existing content
                        UpdateExistingDeveloper();
                        break;
                    case "5":
                        // Delete existing content
                        DeleteDeveloper();
                        break;
                    case "6":
                        // List of developers that need access to PluralSight
                        DevelopersNoAccessPluralSight();
                        break;
                    case "7":
                        // Enter into a new console
                        GoToDeveTeamUI();
                        break;
                    case "8":
                        // Exit
                        Console.WriteLine("Good Bye!!");
                        keepRunning = false; // breaks while loop
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DisplayDeveloperAll()
        {

            Console.Clear();

            List<Developer> developerList = _developerList.GetDeveloperList();


            foreach (Developer developer in developerList)
            {
                Console.WriteLine("Name: " + developer.FirstName + " " + developer.LastName + "\n" +
                "Developer ID: " + developer.DeveloperID + "\n" +
                "PluralSight Access:" + developer.PluralSight + "\n" +
                "Team Name: " + developer.DeveloperTeamID + "\n");
                
            }
        }

        private void DisplayDeveloperByID()
        {
            Console.Clear();

            Console.WriteLine("Enter in the ID that you would like to find:");

            // Get the user's input
            string input = Console.ReadLine();

            Developer developerList = _developerList.GetDeveloperByID(input);


            if (developerList != null)
            {

                Console.WriteLine("Congrats.  We were able to find the developer with the name " + developerList.FirstName + " " + developerList.LastName + "\n" +
                "and a developer ID of " + developerList.DeveloperID + ". Their PluralSight access: " + developerList.PluralSight + 
                ". They are a member of the: " + developerList.DeveloperTeamID);

            } else {

                Console.WriteLine("I could not find the " + input + " in the list of developers.");
            
            }
        }

        private void CreateNewDeveloper()
        {
            Console.Clear();

            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter first name of developer:");
            newDeveloper.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name of developer:");
            newDeveloper.LastName = Console.ReadLine();

            Console.WriteLine("Enter in the developer's ID:");
            newDeveloper.DeveloperID = Console.ReadLine();

            Console.WriteLine("Does the developer have access to PluralSight (y /n):");
            newDeveloper.PluralSight = Console.ReadLine();

            Console.WriteLine("What Team are they a member?");
            newDeveloper.DeveloperTeamID = Console.ReadLine();

            _developerList.AddDeveloperToList(newDeveloper);
        }

        private void UpdateExistingDeveloper()
        {
            DisplayDeveloperAll();

            Console.WriteLine("Enter in the ID of the developer you would like to update:");
            string input = Console.ReadLine();

            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter first name of developer:");
            newDeveloper.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name of developer:");
            newDeveloper.LastName = Console.ReadLine();

            Console.WriteLine("Enter in the develoepr's ID:");
            newDeveloper.DeveloperID = Console.ReadLine();

            Console.WriteLine("Enter in if they have access to PluralSight (y / n)");
            string accessToPluralSight = Console.ReadLine().ToLower();

           // Console.WriteLine("Enter in the team ID:");
            // newDeveloper.DeveloperTeamID = Console.ReadLine();


            bool wasUpdated = _developerList.UpdateListOfDevelopers(input, newDeveloper);

        }

        private void DeleteDeveloper()
        {
            Console.WriteLine("Enter in the developer ID you would like to delete:");
            string input = Console.ReadLine();

            bool wasDeleted = _developerList.RemoveDeveloperFromList(input);

            if(wasDeleted)
            {
                
                Console.WriteLine("The developer was deleted from list:");
            
            } else {

                Console.WriteLine("The developer was NOT deleted from list. Try again.");
            
            }
        }

        private void DevelopersNoAccessPluralSight()
        {

            List<Developer> developerList = _developerList.GetDeveloperList();


            foreach (Developer developer in developerList)
            {
                if (developer.PluralSight == "y")
                {
                    continue;

                } else {

                    Console.WriteLine("Name: " + developer.FirstName + " " + developer.LastName + "\n" +
                    "Developer ID: " + developer.DeveloperID + "\n" +
                    "PluralSight Access:" + developer.PluralSight);
                }
            }
        }


        private void GoToDeveTeamUI()
        {
            Console.Clear();
            DevTeamUI program = new DevTeamUI();
            program.Run();

        }

        private void SeedDeveloperList()
        {
            Developer joeProgramer = new Developer("Joe", "Smith", "12345", "y", "8888");
            _developerList.AddDeveloperToList(joeProgramer);

            Developer fredProgramer = new Developer("Fred", "Arch", "1111", "n", "8888");
            _developerList.AddDeveloperToList(fredProgramer);

            Developer jillProgramer = new Developer("Jill", "Isthebest", "834928394", "y", "1234");
            _developerList.AddDeveloperToList(jillProgramer);

        }

    }
}
