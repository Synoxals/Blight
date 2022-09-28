using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;

public class MyProgram
{
    private static Random random = new Random();
    public static void Main(string[] args)
    {
        ConsoleKeyInfo Choice;
        int test;
        test = 0;
        bool testing = true;
        int option = 1;
        int CWeapon = 0;
        string LeaveWord = ">Leave [C]";
        int DeleteCount = 0;
        bool Buffer = true;


        if (testing != true)
        {
            Typewrite("You wake up shivering, drenched in cold sweat.");
            Typewrite("As you come to your senses, you begin to remember the events of the previous night.");
            Typewrite("You get out of bed, slowly realising the dull pain in your head. Was it a hangover, or perhaps your looming regret?");
            TypewriteNS("You may ");
            TypewriteRedNS("leave");
            TypewriteNS(", ");
            TypewriteRedNS("look around "); //Future note to self: RedNS means Red Text with no jump to next line (no space)
            TypewriteNS("or ");
            TypewriteRedNS("search ");
            Typewrite("the room.");
        }




        while (test < 100)  // Test variable only for testing, not to be used in final product
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            TypewriteBlue1(">Look Around [Z]\n>Search [X]\n" + LeaveWord);
            Choice = Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;





            if (Choice.Key == ConsoleKey.Z)  // If/Elif statements that activate individual functions based on user input
            {
                DeleteCount = 0;
                while (DeleteCount < 3)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    DeleteCount++;
                }
                LookAround(option);

            }
            else if (Choice.Key == ConsoleKey.X && (option != 1))
            {
                DeleteCount = 0;
                while (DeleteCount < 3)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    DeleteCount++;
                }

                Search(option);

            }
            else if (Choice.Key == ConsoleKey.X && option == 1)
            {
                DeleteCount = 0;
                while (DeleteCount < 3)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    DeleteCount++;
                }

                Search(option);
                CWeapon++;
                Console.WriteLine(@"                                                       ___
                                                      |_  |
                                                        | |
__                      ____                            | |
\ ````''''----....____.'\   ````''''--------------------| |--.               _____      .-.
 :.                      `-._                           | |   `''-----''''```     ``''|`: :|
  '::.                       `'--.._____________________| |                           | : :|
    '::..       ----....._______________________________| |                           | : :|
      `'-::...__________________________________________| |   .-''-..-'`-..-'`-..-''-.| : :|
           ```'''---------------------------------------| |--'                         `'-'
                                                        | |
                                                       _| |
                                                      |___| 
");

            }
            else if (Choice.Key == ConsoleKey.C)
            {
                DeleteCount = 0;
                while (DeleteCount < 3)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    DeleteCount++;
                }
                Leave(option);
                option++;


            }
        }



            static void LookAround(int option)
            {
                IDictionary<int, string> Descriptions = new Dictionary<int, string>();
                Descriptions.Add(1, "The room around you is messy. Clothes littered across the floor and stacks of cans left on the desk.");
                Descriptions.Add(2, "The corridor is deserted.");
                Descriptions.Add(3, "You go out into the world. Something feels off.");

                Typewrite(Descriptions[option]);
                Console.WriteLine("");

            } // Functions that handle looking around, searching the area, the currently equipped weapon and leaving the room

            
            static int Weapons(int CWeapon)
            {
                IDictionary<int, int> Weapons = new Dictionary<int, int>();
                Weapons.Add(1, 15);
                Weapons.Add(2, 25);
                Weapons.Add(3, 40);

                int Weapon = Weapons[CWeapon];

                return Weapon;

            }

            
            static void Search(int option)
            {
                IDictionary<int, string> Search = new Dictionary<int, string>();
                Search.Add(1, "You search through the clutter of cans on your desk, and find a small pocket knife.");
                Search.Add(2, "There is nothing for you here.");
                Search.Add(3, "The room around you is messy. Clothes littered across the floor and stacks of cans left on the desk.");

                Typewrite(Search[option]);
                Console.WriteLine("");

            }

            
            static void Leave(int option)
            {
                IDictionary<int, string> Leave = new Dictionary<int, string>();
                Leave.Add(1, "You exit your room into the corridor. The house is silent.");
                Leave.Add(2, "You go out into the outside world. Something seems off.");
                Leave.Add(3, "The room around you is messy. Clothes littered across the floor and stacks of cans left on the desk.");

                Typewrite(Leave[option]);
                Console.WriteLine("");

            }
          
        
            static void Locations(int option)
            {
                IDictionary<int, string> Place = new Dictionary<int, string>();
                Place.Add(1, "The Bedroom.");
                Place.Add(2, "Corridor.");
                Place.Add(3, "Front Garden.");

                Typewrite(Place[option]);
                Console.WriteLine("");
            }


            static void Fight(int CWeapon)
            {

                    int enemyHitpoints;
                    int playerHitpoints;
                    int playerStrength;
                    int playerSpeed;
                    int enemySpeed;
                    int enemyStrength;
                    int enemyChoice;

                    enemyChoice = random.Next(2);
                    enemyHitpoints = 100;
                    playerHitpoints = 100;
                    playerStrength = Weapons(CWeapon);
                    playerSpeed = 40;
                    enemySpeed = 50;
                    enemyStrength = 15;
                    int es2;
                    string attDef;

                    es2 = enemyStrength;
                    int ps2;

                    ps2 = playerStrength;
                    while (playerHitpoints > 0 && enemyHitpoints > 0)
                    {
                        while (enemyHitpoints > 0)
                        {
                            if (playerSpeed > enemySpeed)
                            {
                                Console.WriteLine("Do you want to attack or guard?");
                                attDef = Console.ReadLine();
                                int enemyTurn;

                                enemyTurn = 0;
                                if (playerHitpoints > 0 && enemyHitpoints > 0)
                                {
                                }
                                else
                                {
                                    if (playerHitpoints > 0)
                                    {
                                        if (enemyHitpoints > 0)
                                        {
                                        }
                                        else
                                        {
                                            Console.WriteLine("The enemy has been slain.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The player was slain.");
                                    }
                                }
                                if (attDef == "attack" && playerHitpoints > 0)
                                {
                                    if (enemyChoice == 0)
                                    {
                                        Console.WriteLine("The enemy blocked your attack.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You swing your sword at your opponent.");
                                        enemyHitpoints = enemyHitpoints - playerStrength;
                                    }
                                    Console.WriteLine("The enemy is left with: " + enemyHitpoints + "hp.");
                                }
                                else
                                {
                                    if (attDef == "guard" && playerHitpoints > 0)
                                    {
                                        Console.WriteLine("You raise your sword defensively.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The player was slain.");
                                    }
                                }
                                if (enemyTurn == 0)
                                {
                                    enemyChoice = 1;
                                }
                                if (enemyChoice == 1 && enemyHitpoints > 0)
                                {
                                    if (attDef == "guard")
                                    {
                                        Console.WriteLine("You blocked the enemy's attack.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The opponent swings their sword at you.");
                                        playerHitpoints = playerHitpoints - enemyStrength;
                                    }
                                    Console.WriteLine("You are left with: " + playerHitpoints + "hp.");
                                }
                                else
                                {
                                    if (enemyHitpoints > 0)
                                    {
                                        Console.WriteLine("The enemy defends.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The opponent was slain.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Do you want to attack or guard?");
                                attDef = Console.ReadLine();
                                Console.WriteLine("It is your opponent's turn.");
                                int enemyTurn;

                                enemyTurn = 1;
                                if (enemyChoice == 1 && enemyHitpoints > 0)
                                {
                                    Console.WriteLine("The opponent swings their sword at you.");
                                    if (attDef == "guard")
                                    {
                                        Console.WriteLine("You block the opponent's attack.");
                                    }
                                    else
                                    {
                                        playerHitpoints = playerHitpoints - enemyStrength;
                                    }
                                    Console.WriteLine("You are left with: " + playerHitpoints + "hp.");
                                }
                                else
                                {
                                    if (enemyHitpoints > 0)
                                    {
                                        Console.WriteLine("The enemy defends.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The opponent was slain.");
                                    }
                                }
                                enemyTurn = 0;
                                if (playerHitpoints > 0 && enemyHitpoints > 0)
                                {
                                }
                                else
                                {
                                    if (playerHitpoints > 0)
                                    {
                                        if (enemyHitpoints > 0)
                                        {
                                        }
                                        else
                                        {
                                            Console.WriteLine("The enemy has been slain.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The player was slain.");
                                    }
                                }
                                if (attDef == "attack" && playerHitpoints > 0)
                                {
                                    if (enemyChoice == 0)
                                    {
                                        Console.WriteLine("The enemy blocked your attack.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You swing your sword at your opponent.");
                                        enemyHitpoints = enemyHitpoints - playerStrength;
                                    }
                                    Console.WriteLine("The enemy is left with: " + enemyHitpoints + "hp.");
                                }
                                else
                                {
                                    if (attDef == "guard" && playerHitpoints > 0)
                                    {
                                    }
                                    else
                                    {
                                        if (playerHitpoints > 0)
                                        {
                                            Console.WriteLine("Invalid input.");

                                            // Needs a while loop here or it'll just skip the player's turn
                                        }
                                        else
                                        {
                                            Console.WriteLine("The player was slain.");
                                        }
                                    }
                                }
                            }
                            enemyChoice = random.Next(2);
                        }
                        Console.WriteLine("The battle ends.");
                    }
            
            } // The battle function



            // .NET can only read single characters or entire lines from the console.
            // The following function safely reads a double value.
            static double readValue()
            {
                double result;
                while (!double.TryParse(Console.ReadLine(), out result)) ;
                return result;
            }

            
            static void sleep(int sleep)
                {
                    Thread.Sleep(sleep * 1000);
                } // Various functions that handle text colour formatting and wait times in between text

            
            static void Typewrite(string message)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(40);
                }
                sleep(1);
                Console.WriteLine("");


            }
            
        
            static void TypewriteBlue(string message)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(40);
                }
                sleep(1);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;


            }


            static void TypewriteNS(string message)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(40);
                }



            }


            static void TypewriteRedNS(string message)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(message[i]);
                        System.Threading.Thread.Sleep(40);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }


            static void TypewriteBlueNS(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(40);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


            static void TypewriteRed1(string message) 
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(0);
                }
                sleep(0);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;


        } 
            static void TypewriteBlue1(string message)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(message[i]);
                    System.Threading.Thread.Sleep(0);
                }
                sleep(0);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;


            }

            static void ClearCurrentConsoleLine()
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, currentLineCursor);
            }
    }
    
}