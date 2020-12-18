using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Komodo_Insurance
{
    class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a new option\n" +
                    "1. Create New Badge\n" +
                    "2. Update doors on an existing badge\n" +
                    "3. Delete all doors from an existing badge\n" +
                    "4. Show a list with all badge numbers and door access\n" +
                    "5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": //create new badge
                        CreateNewBadge();
                        break;
                    case "2": //update doors
                        UpdateDoorsOnBadge();
                        break;
                    case "3": //Delete all doors from badge
                        DeleteAllDoorsFromBadge();
                        break;
                    case "4": //show a list of all
                        ShowListOfAllBadgeInfo();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid numer.");
                        break;
                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewBadge()
        {

        }

        private void UpdateDoorsOnBadge()
        {

        }

        private void DeleteAllDoorsFromBadge()
        { 
        
        }

        private void ShowListOfAllBadgeInfo()

        { 
        
        }
    }
}
