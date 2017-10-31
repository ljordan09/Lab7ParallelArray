using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7ArrayProject
{
    class Program
    {
        public static string[] names = new string[] { "Jordan", "Bert", "Hayes", "Chanell", "Anthony", "Eric", "Dave", "Kai", "Jace", "Larry", "Ray" };
        public static string[] food = new string[] { "jello", "Bread", "Happy Meals", "Canoli", "Apple Pie", "Elephant Ears", "Dairy", "Kit Kats", "Jack Fruit", "Lobster", "Ricotta Cheese" };
        public static string[] town = new string[] { "Jasper", "Brooklyn", "Hartford", "Cleveland", "Ann Arbor", "East Jordan", "Davison", "Kent", "Jeruselum", "Lafayette", "Richmond" };
        static void Main(string[] args)
        {
            do
            {
                int GetNumber;

                string firstInput = Prompt();

                GetNumber = StudentPicker(firstInput);

                Console.WriteLine("Please type 'Food' or 'Town' to find out more about them : ");

                string secondInput = Console.ReadLine().ToLower();

                int favFood = 0;

                favFood = StudentInfo(GetNumber, ref secondInput);

                Console.WriteLine(DoAgain());

            } while (true);

        }
        private static string Prompt()
        {
            Console.Write($"Enter a number from 1-11 to find out about a student : ");
            Console.WriteLine("\n<><><><><><<><>><><><><><><><><><><><><><><><><><><><>");
            string firstInput = Console.ReadLine();
            return firstInput;
        }

        private static int StudentPicker(string firstInput)
        {
            int myInt;
            if (int.TryParse(firstInput, out myInt))
            {
                Console.WriteLine($"The student is {names[myInt - 1]}");
            }

            else if (myInt < 0 || myInt >= 12)
            {
                Console.WriteLine("You must enter a number between 1-11");
            }

            return myInt;
        }

        private static int StudentInfo(int myInt, ref string secondInput)
        {
            int favFood;
            while (true)
            {
                if (int.TryParse(secondInput, out favFood))
                {
                    Console.WriteLine("You must enter a number between 1-11 ");
                    Console.Write("Press enter to reach exit menu.\n Please type \"Food\" or 'Town' to find out more about them : ");
                    secondInput = Console.ReadLine().ToLower();
                }
                else if (secondInput == "food")
                {
                    for (int i = 0; i < food.Length; i++)
                    {
                        if (myInt == i)
                        {
                            Console.WriteLine($"{names[i - 1]}'s favorite food is: {food[i - 1]} ");
                            Console.WriteLine("\nPress enter to move on.");
                            Console.WriteLine("\nPlease type 'Food' or 'Town' to find out more about them :");
                            secondInput = Console.ReadLine();
                            break;
                        }
                    }
                }
                else if (secondInput == "town")
                {
                    for (int i = 0; i < town.Length; i++)
                    {
                        if (myInt == i)
                        {
                            Console.WriteLine($"{names[i - 1]}'s homtown is: {town[i - 1]} ");
                            Console.WriteLine("\nPress enter to move on.");
                            Console.WriteLine("\nPlease type 'Food' or 'Town' to find out more about them :");
                            secondInput = Console.ReadLine();
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return favFood;
        }
        
        public static string DoAgain()
        {
            while (true)
            {
                Console.Write("\nDo you want to look up another student? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return ("Great! ");
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine("Thanks!");
                    
                    Environment.Exit(0);
                }
            }
        }

    }
}
