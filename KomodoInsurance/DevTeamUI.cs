using Developer_Repository;
using DevTeam_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoInsurance_Console
{
    public class DevTeamUI
    {
        private DevTeamRepo _teamList = new DevTeamRepo();
        private DeveloperRepo _devRepo = new DeveloperRepo();

        public void Run()
        {
            SeedTeamList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Select a menu option: \n" +
                   "1. List of Teams \n" +
                   "2. Create Team \n" +
                   "3. Delete Team \n" +
                   "4. See Developers in a Team \n" +
                   "5. Add Developer to Team \n" +
                   "6. Remove Developer From Team \n" +
                   "7. Go to Developer Team Console \n" +
                   "8. Exit");

                //Get the users input
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Display list of all teams
                        DisplayTeams();
                        break;
                    case "2":
                        // Create a new team
                        CreateATeam();
                        break;
                    case "3":
                        // Delete a team
                        DeleteTeam();
                        break;
                    case "4":
                        // See Developers in a team
                        DevelopersInATeam();
                        break;
                    case "5":
                        // Add a Developer to a team
                        AddDeveloperToTeam();
                        break;
                   /*      case "6":
                             // Remove a Developer from a team
                             DeleteDeveloperFromTeam();
                             break; */
                    case "7":
                        // Go to the Dev Team Console
                        GoToDeveloperUI(); 
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

        private void DisplayTeams()
        {
            Console.Clear();

            List<DevTeam> teamList = _teamList.GetTeamList();


            foreach (DevTeam team in teamList)
            {
                Console.WriteLine("Team Name: " + team.TeamName + "\n" +
                "Team ID: " + team.TeamID + "\n");

            }
        }

        private void CreateATeam()
        {
            Console.Clear();

            DevTeam newTeam = new DevTeam();

            Console.WriteLine("Enter name of team:");
            newTeam.TeamName = Console.ReadLine().ToLower();

            Console.WriteLine("Enter in the Team's ID:");
            newTeam.TeamID   = Console.ReadLine().ToLower();

            _teamList.AddNewTeam(newTeam);

        }

        public void DeleteTeam()
        {
            
            Console.WriteLine("Enter the team name you would like to delete:");
            string input = Console.ReadLine().ToLower();

            bool wasDeleted = _teamList.DeleteTeam(input);

            if (wasDeleted)
            {
                Console.WriteLine("Team was deleted from list:");
            }
            else
            {
                Console.WriteLine("Team was NOT deleted from list. Try again.");
            }

        }

        private void DevelopersInATeam()
        {

            DisplayTeams();
            Console.WriteLine("What team would you like to see the membership? Enter Team ID");
            string input = Console.ReadLine().ToLower();

            
            List<Developer> localDevList = _devRepo.GetDeveloperList();

            foreach (Developer developer in localDevList)
            {

                if (developer.DeveloperTeamID == input)
                {
                    Console.WriteLine(developer.FirstName + " " + developer.LastName);
                }
            }
        }

        private void AddDeveloperToTeam()
        {

            Console.Clear();

            List<Developer> localDevList = _devRepo.GetDeveloperList(); // creates an instance of developer

            foreach (Developer developer in localDevList)
            {
                Console.WriteLine("Name: " + developer.FirstName + " " + developer.LastName + "\n" +
                "Developer ID: " + developer.DeveloperID + "\n");

            }

            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter in the ID of the developer you would like to update:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter in the team ID:");
            newDeveloper.DeveloperTeamID = Console.ReadLine();

            bool wasUpdated = _devRepo.UpdateTeamforDeveloper(input, newDeveloper);

        }

        private void GoToDeveloperUI()
        {
            Console.Clear();

            DeveloperUI program = new DeveloperUI();
            program.Run();

        }

        //HELPER Methods

        private void SeedTeamList()
        {
            DevTeam firstTeam = new DevTeam("Article 1", "8888");
            _teamList.AddNewTeam(firstTeam);

            DevTeam secondTeam = new DevTeam("Great Team", "1234");
            _teamList.AddNewTeam(secondTeam);

        }



    } //End Dev Team UI Class
} //End Name Space
