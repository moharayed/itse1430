//Name: Mohammed Rayed
//Class: Itse1430
//Project: Maze program

using System;

namespace Itse1430.Maze
{
    enum Command
    {
        Quit = 1,
        Move = 2,
        Turn = 3,
        MoveForward = 4,
        MoveRight = 5,
        MoveBackward = 6,
        MoveLeft = 7,
        North = 8,
        East = 9,
        South = 10,
        West = 11,
        Cancel = 12          //Cancel is just a place holder for certain areas
    }
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            var oneTime = 1;
            while (true)
            {
                Command direction = Command.North;
                while (oneTime == 1)
                {
                    Console.WriteLine ("".PadLeft (100, '*'));
                    Console.WriteLine ("* The reason why you're here is beacuse As you were traveling, you heard                           *");
                    Console.WriteLine ("* from a civilian that there was a shortcut to leave get to the next town.                         *");
                    Console.WriteLine ("* You decide to go take that shortcut becasue of how much time you will save in order to get there.*");
                    Console.WriteLine ("".PadLeft (100, '*'));
                    --oneTime;
                }
                Console.WriteLine ("");
                Console.WriteLine ("Would you like to move into the tunnel?");
                Console.WriteLine ("1) Yes");
                Console.WriteLine ("2) Quit");


                string input = Console.ReadLine ();
                input = input.ToLower ();
                if (input == "yes")
                {
                    RoomOne (direction);
                } else if (input == "quit")
                {
                    Console.WriteLine ("Are you sure?");
                    Console.WriteLine ("1) Yes");
                    Console.WriteLine ("2) No");
                    string quitYN = Console.ReadLine ();
                    quitYN = quitYN.ToLower ();

                    if (quitYN == "yes")
                    {
                        System.Environment.Exit (0);
                    } else if (quitYN == "no")
                    {
                        Console.WriteLine ("");
                    }
                } else
                {
                    Console.WriteLine ("Not a valid input");
                }
            }
        }
        static void RoomOne ( Command direction )
        {
            var oneTime = 1;
            while (oneTime == 1)
            {
                Console.WriteLine ("Oh no! the entrance beside you was blocked off. You have to find a way out! Find the room with the Exit.");
                --oneTime;
            }
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 1");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomEleven (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomTwo (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomTen (direction);
                        }
                    }
                }
            }
        }
        static void RoomTwo ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 2");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomThree (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomOne (direction);
                        }
                    }
                }
            }
        }
        static void RoomThree ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 3");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomFour (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomTwo (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomEleven (direction);
                        }
                    }
                }
            }
        }
        static void RoomFour ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 4");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomFive (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomThree (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomThirteen (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomTwelve (direction);
                        }
                    }
                }
            }
        }
        static void RoomFive ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 5");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomSeventeen ();
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomFour (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomFifteen (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomSix (direction);
                        }
                    }
                }
            }
        }
        static void RoomSix ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 6");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomTwelve (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomFive (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomSeven (direction);
                        }
                    }
                }
            }
        }
        static void RoomSeven ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 7");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomEight (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomSix (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomSixteen (direction);
                        }
                    }
                }
            }
        }
        static void RoomEight ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 8");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomSeven (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomNine (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomTwelve (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomFourteen (direction);
                        }
                    }
                }
            }
        }
        static void RoomNine ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 9");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomEight (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomTen (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomEleven (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            Console.WriteLine ("That leads us no where.");
                        }
                    }
                }
            }
        }
        static void RoomTen ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 10");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomNine (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomOne (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            Console.WriteLine ("That leads us no where.");
                        }
                    }
                }
            }
        }
        static void RoomEleven ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 11");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomTwelve (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomOne (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomThree (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomNine (direction);
                        }
                    }
                }
            }
        }
        static void RoomTwelve ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 12");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomSix (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomEleven (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomFour (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomEight (direction);
                        }
                    }
                }
            }
        }
        static void RoomThirteen ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 13");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomFifteen (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomFour (direction);
                        }
                    }
                }
            }
        }
        static void RoomFourteen ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 14");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            RoomSixteen (direction);
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomEight (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            Console.WriteLine ("That leads us no where.");
                        }
                    }
                }
            }
        }
        static void RoomFifteen ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 15");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomThirteen (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveRight)
                        {
                            RoomFive (direction);
                        }
                    }
                }
            }
        }
        static void RoomSixteen ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ("");
                Console.WriteLine ("You're in room 16");
                Console.WriteLine ($"You're facing {direction}");

                Command command = GetCommand ();

                if (command == Command.Turn)
                {
                    direction = HandleCommand (command, direction);
                } else
                {
                    Command handledCommand = HandleCommand (command, direction);

                    if (command == Command.Move)
                    {
                        if (handledCommand == Command.MoveForward)
                        {
                            Console.WriteLine ("That leads us no where.");
                        } else if (handledCommand == Command.MoveBackward)
                        {
                            RoomFourteen (direction);
                        } else if (handledCommand == Command.MoveLeft)
                        {
                            RoomSeven (direction);
                        } else if (handledCommand == Command.MoveRight)
                        {
                            Console.WriteLine ("That leads us no where.");
                        }
                    }
                }
            }
        }
        static void RoomSeventeen ()
        {
            Console.WriteLine ("You've entered Room 17");
            Console.WriteLine ("***** CONGRATULATIONS YOU HAVE FOUND THE EXIT *****");
            System.Environment.Exit (0);
        }

        static Command GetCommand ()
        {
            Console.WriteLine ("");
            Console.WriteLine ("What would you like to do?");
            Console.WriteLine ("1) Move");
            Console.WriteLine ("2) Turn");
            Console.WriteLine ("3) Quit");

            while (true)
            {
                string input = Console.ReadLine ();
                Command command = ParseCommand (input);
                if (command != Command.Cancel)
                    return command;

            }
        }

        static Command HandleCommand ( Command command, Command direction )
        {
            string input;

            if (command == Command.Quit)
            {
                Console.WriteLine ("Are you sure?");
                Console.WriteLine ("1) Yes");
                Console.WriteLine ("2) No");

                input = Console.ReadLine ();
                input = input.ToLower ();

                if (input == "yes")
                {
                    System.Environment.Exit (0);
                } else if (input == "no")
                {
                    Console.WriteLine ("");
                } else
                {
                    Console.WriteLine ("Invalid Input");
                }

            }

            if (command == Command.Move)
            {
                command = MoveCommand (direction);
                return command;
            }

            if (command == Command.Turn)
            {
                command = TurnCommand (direction);
                return command;
            }

            return Command.Cancel;
        }

        static Command TurnCommand ( Command direction )
        {
            while (true)
            {
                Console.WriteLine ($"You are facing {direction}. Would you like to...");
                Console.WriteLine ("Turn left");
                Console.WriteLine ("Turn right");
                Console.WriteLine ("Turn around");
                Console.WriteLine ("(Please write the whole phrase)");
                string input = Console.ReadLine ();
                input = input.ToLower ();

                if (direction == Command.North)
                {
                    if (input == "turn left")
                    {
                        return Command.West;
                    } else if (input == "turn right")
                    {
                        return Command.East;
                    } else if (input == "turn around")
                    {
                        return Command.South;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.East)
                {
                    if (input == "turn left")
                    {
                        return Command.North;
                    } else if (input == "turn right")
                    {
                        return Command.South;
                    } else if (input == "turn around")
                    {
                        return Command.West;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.South)
                {
                    if (input == "turn left")
                    {
                        return Command.East;
                    } else if (input == "turn right")
                    {
                        return Command.West;
                    } else if (input == "turn around")
                    {
                        return Command.North;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.West)
                {
                    if (input == "turn left")
                    {
                        return Command.South;
                    } else if (input == "turn right")
                    {
                        return Command.North;
                    } else if (input == "turn around")
                    {
                        return Command.East;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                }

            }
        }

        static Command MoveCommand ( Command direction )
        {
            while (true)
            {

                Console.WriteLine ("Would you like to...");
                Console.WriteLine ("Move Forward");
                Console.WriteLine ("Move Backward");
                Console.WriteLine ("Move Left");
                Console.WriteLine ("Move Right");
                Console.WriteLine ("(Please write the whole phrase)");
                Console.WriteLine ("");
                string input = Console.ReadLine ();
                input = input.ToLower ();

                if (direction == Command.North)
                {
                    if (input == "move forward")
                    {
                        return Command.MoveForward;
                    } else if (input == "move backward")
                    {
                        return Command.MoveBackward;
                    } else if (input == "move left")
                    {
                        return Command.MoveLeft;
                    } else if (input == "move right")
                    {
                        return Command.MoveRight;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.East)
                {
                    if (input == "move forward")
                    {
                        return Command.MoveRight;
                    } else if (input == "move backward")
                    {
                        return Command.MoveLeft;
                    } else if (input == "move left")
                    {
                        return Command.MoveForward;
                    } else if (input == "move right")
                    {
                        return Command.MoveBackward;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.South)
                {
                    if (input == "move forward")
                    {
                        return Command.MoveBackward;
                    } else if (input == "move backward")
                    {
                        return Command.MoveForward;
                    } else if (input == "move left")
                    {
                        return Command.MoveRight;
                    } else if (input == "move right")
                    {
                        return Command.MoveLeft;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else if (direction == Command.West)
                {
                    if (input == "move forward")
                    {
                        return Command.MoveLeft;
                    } else if (input == "move backward")
                    {
                        return Command.MoveRight;
                    } else if (input == "move left")
                    {
                        return Command.MoveBackward;
                    } else if (input == "move right")
                    {
                        return Command.MoveForward;
                    } else
                    {
                        Console.WriteLine ("Invalid Input.");
                    }
                } else
                {
                    return Command.Cancel;
                }
            }
        }
        static Command ParseCommand ( string input )
        {
            if (!String.IsNullOrEmpty (input))
                input = input.ToLower ();

            if (input == "move")
            {
                return Command.Move;
            } else if (input == "turn")
            {
                return Command.Turn;
            } else if (input == "quit")
            {
                return Command.Quit;
            } else
            {
                Console.WriteLine ("Invalid input.");
                return Command.Cancel;
            }
        }
    }
}

