using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            //string title;
            //int runLength;
            //int releaseYear;
            //string description;
            //bool haveSeen;
            var quit = false;
            while (!quit)
            {
                char input = DisplayMenu ();
                switch (input)
                {
                    //Fallthrough allowed only if case is empty
                    case 'a':
                    case 'A': AddMovie (); break;

                    //Must have break/return at end of each case
                    case 'D': DisplayMovie (); break;
                    case 'R': RemoveMovie (); break;
                    case 'Q':
                    {
                        quit = true;
                        break;
                    }
                    default: Console.WriteLine ("Not Supported"); break;
                };


                //if (input == 'A')
                //{
                //    AddMovie ();
                //} 
                //else if (input == 'D')
                //{
                //    DisplayMovie ();
                //}
                //else if (input == 'R')
                //{
                //    RemoveMovie ();
                //}
                //else if (input == 'Q')
                //{
                //    break;
                //}
            };
        }

        private static void RemoveMovie()
        {
            //Confirm Movie
            //Please DONT do this expression == true, expression
            if (!ReadBoolean ($"Are you sure you want to remove {title}? "))
                return;

            //Remove movie
            title = null;
        }

        static void AddMovie ()
        {
            //Get title
            Console.Write ("Title: ");
            title = Console.ReadLine ();

            //Get Description
            Console.Write ("Description: ");
            description = Console.ReadLine ();

            //Get release year
            releaseYear = ReadInt32 ("Release Year: ");

            //Get run length
            runLength = ReadInt32 ("Run Length: (In minutes) ");

            //Get have seen
            hasSeen = ReadBoolean ("Have See? ");

        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.Write (message);

                var input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                //int result;
                //if (Int32.TryParse (input, out result))
                if (Int32.TryParse (input, out var result))
                    return result;

                Console.WriteLine ("Not a number");
            }
        }

        static void DisplayMovie ()
        {
            //Display message if no movies
            if (String.IsNullOrEmpty(title))
            {
                Console.WriteLine ("No movies");
                return;
            };

            //Title, description, release year, run length, hasSeen
            Console.WriteLine (title);
            Console.WriteLine (description);

            //Formatting String
            //1) String Concat
            Console.WriteLine ("Released " + releaseYear);

            //2) Printf
            //Console.WriteLine ("Run Time: {0}", runLength);

            //3) String Formatting
            var formattedString = String.Format ("Run time: {0}", runLength);
            Console.WriteLine (formattedString);

            //4) String Interpulation
            Console.WriteLine ($"Seen it? {hasSeen}");
            
            //String.Compare ("", "", StringComparison.);
            Console.WriteLine ("".PadLeft (50, '-'));
        }

        static bool ReadBoolean ( string message )
        {
            while (true)
            {
                Console.Write (message);

                string input = Console.ReadLine ();

                //int result = Int32.Parse (input);
                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;

                Console.WriteLine ("Not a boolean");
            }
        }

        static char DisplayMenu()
        {
            do
            {
                Console.WriteLine ("A)dd a movie");
                Console.WriteLine ("D)isplay movie");
                Console.WriteLine ("R)emove movie");
                Console.WriteLine ("Q)uit");

                string input = Console.ReadLine ();

                //Lower case
                input = input.ToLower ();
                //if (input == "a")
                if (String.Compare (input, "a", true) == 0)
                {
                    return 'A';
                } 
                else if (input == "q")
                {
                    return 'Q';
                } 
                else if (input == "d")
                {
                    return 'D';
                }
                else if (input == "r")
                {
                    return 'R';
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

        static void DemoArray ()
        {
            double[] payRates = new double[100];

            //50th element to 7.25
            payRates[49] = 7.25;

            //Read 89th element into temp variable
            double payRate = payRates[88];

            //Print out the 80th element
            Console.WriteLine (payRates[79]);

            //An empty array
            bool[] isPassing = new bool[0];

            //Enumerating an array
            for (int index = 0; index < payRates.Length; ++index)
                Console.WriteLine (payRates[index]);

            //Type inferencing
            //string name = "Bob William Smith Jr III";
            var name = "Bob William Smith Jr III";
            //name = 20;

            string[] nameParts = name.Split (' ');
        }

        static void DemoString()
        {
            string str = null;

            //Checking for null
            if (str != null)
                str = str.ToLower ();

            //Checking for null  or empty string
            if (str != null && str != "")
                str = str.ToLower ();

            //Length - NO
            if (str != null && str.Length == 0)
                str = str.ToLower ();

            //Empty - No
            if (str != null && str != String.Empty)
                str = str.ToLower ();

            // Correct Approach
            if (!String.IsNullOrEmpty(str))
                str = str.ToLower ();
        }

        //Don't do this outside lab 1
        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static bool hasSeen;
    }
}
