using System;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to our story.");


        Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");


        Console.WriteLine("Type YES or NO");


        string word = Console.ReadLine();
        word = word.ToUpper();

        //6
        //saved

        //7
        Console.WriteLine();
        Console.WriteLine();
        if (word == "NO")
        { Console.WriteLine("Not much of an adventure if we don't leave our room, you might as well go to sleep. THE END.");
            GameOver();
        }

        //8
        else if (word == "YES")
        {
            //9
            Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?\n \n");


            //10

            Console.WriteLine("OPEN or KNOCK:");
            string doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();

            //11

            if (doorChoice == "KNOCK")
            {

                //12
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?");
                Console.WriteLine();
                Console.WriteLine();

                //13
                Console.WriteLine("Type your answer:");
                string riddleAnswer = Console.ReadLine();
                riddleAnswer = riddleAnswer.ToUpper();

                //14
                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and make sure you lock the door. THE END.");
                    GameOver();

                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
                    GameOver();
                }

            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");

                Console.WriteLine("Enter the number of the key you would like to use (1-3)");
                string keyChoice = Console.ReadLine();
                keyChoice = keyChoice.ToUpper();


                switch (keyChoice)
                {
                    //18
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
                            GameOver();
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
                        GameOver();
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                        GameOver();
                        break;
                    default:
                        Console.WriteLine("You only have 3 keys");
                        GameOver();
                        break;
                }

                
            }

            
     
        }



    }

    //Methods ------------------------------------------------------------------------------------------------------------------------

    public static void GameOver()
    {
        Console.WriteLine("\n \n The game is over! Press enter to close the console. \n");
        Console.WriteLine("┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼\r\n██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀\r\n██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼\r\n███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼\r\n██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼\r\n███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼\r\n┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼");
        Console.ReadLine();
    }
}