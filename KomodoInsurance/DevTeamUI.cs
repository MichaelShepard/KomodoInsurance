using DevTeam_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace KomodoInsurance_Console
{
    class DevTeamUI
    {
        private DevTeamRepo _teamList = new DevTeamRepo();

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
                        /* case "3":
                             // Delete a team
                             DeleteTeam();
                             break;
                         case "4":
                             // See Developers in a team
                             DevelopersInATeam();
                             break;
                         case "5":
                             // Add a Developer to a team
                             AddDeveloeprToTeam();
                             break;
                         case "6":
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
                Console.WriteLine("Press any key to conitnue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DisplayTeams()
        {
            Console.Clear();

            List<TeamList> teamList = _teamList.GetTeamList();


            foreach (TeamList team in teamList)
            {
                Console.WriteLine("Team Name: " + team.TeamName + "\n" +
                "Team ID: " + team.TeamID + "\n");

            }
        }

        private void CreateATeam()
        {
            Console.Clear();

            TeamList newTeam = new TeamList();

            Console.WriteLine("Enter name of team:");
            newTeam.TeamName = Console.ReadLine();

            Console.WriteLine("Enter in the Team's ID:");
            newTeam.TeamID   = Convert.ToInt32(Console.ReadLine());

            _teamList.AddNewTeam(newTeam);

        }


        private void GoToDeveloperUI()
        {
            Console.Clear();

            DeveloperUI program = new DeveloperUI();
            program.Run();

        }

        private void SeedTeamList()
        {
            TeamList firstTeam = new TeamList("Article 1", 123444);
            _teamList.AddNewTeam(firstTeam);

        }


        } //End Dev Team UI Class
} //End Name Space
