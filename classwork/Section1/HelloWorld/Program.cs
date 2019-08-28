using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            string title;
            int runLength;
            int releaseYear;
            string description;
            bool haveSeen;

            while (true)
            {
                char input = DisplayMenu ();
                if (input == 'A')
                {
                    AddMovie ();
                } 
                else if (input == 'Q')
                {
                    break;
                }
            };
        }

        static void AddMovie ()
        {
            //Get title
            //Get Description
            //Get release year
            //Get run length
            //Get have seen

        }
                                  
        static char DisplayMenu()
        {
            do
            {
                Console.WriteLine ("A)dd a movie");
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();
                if (input == "A" || input == "a")
                {
                    return 'A';
                } 
                else if (input == "Q" || input == "q")
                {
                    return 'Q';
                } 
                else
                {
                    Console.WriteLine ("Invalid input");
                };
            } while (true);
        }

        private static void DemoLanguage ()
        {
            string name;

            //string if = "";

            //Definitly assigned
            // name = "Bob";
            string name2 = Console.ReadLine ();
            //name2 = Console.ReadLine ();

            name2 = name = "Sue";
            Console.WriteLine (name);
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World! ");

            int hours = 8;
            double payRate = 15.25;

            double totalPay = payRate * hours;

            string fullName = "Fred" + " " + "Jones";
            Console.WriteLine (fullName);
            Console.WriteLine (totalPay);
        }
    }
}
