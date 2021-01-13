using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterZTeamGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // All selectable characters in the game
            string[] fighters = new string[23] { "SSJ Goku", "SSJ Vegeta", "SS2 Teen Gohan", "Frieza", "Cell", "Majin Buu", "Krillin", "Trunks", "Piccolo", "Android 18", "Android 16", "Adult Gohan", "Goku Blue", "Vegeta Blue", "SS3 Gotenks", "Yamcha", "Tien", "Kid Buu", "Ginyu", "Nappa", "Hit", "Goku Black", "Android 21" };
            string[] dlcFighters1 = new string[8] { "Broly", "Bardock", "Vegito Blue", "Zamasu", "Base Goku", "Base Vegeta", "Android 17", "Cooler" };
            string[] dlcFighters2 = new string[6] { "Jiren", "Videl", "Goku GT", "Janemba", "Gogeta Blue", "Broly DBS" };
            string[] dlcFighters3 = new string[5] { "Kefla", "Ultra Instinct Goku", "Master Roshi", "Super Baby 2", "Gogeta SS4" };

            // Whether to include dlc characters and generate assists
            bool DLC1 = false;
            bool DLC2 = false;
            bool DLC3 = false;
            bool assists = false;

            // Store the generated characters for display
            string character1 = "SSJGoku";
            string character2 = "SSJGoku";
            string character3 = "SSJGoku";

            // Also store the generated assist (A, B or C) for display
            char assist1 = 'A';
            char assist2 = 'A';
            char assist3 = 'A';

            // For storing generated number
            int randomNumber;
            Random rnd = new Random();

            // For storing user input
            string userInput;
            bool includeQuestion = true;


            Console.WriteLine("     ------------------------------------------------");
            Console.WriteLine("     -- Dragon Ball FighterZ Random Team Generator --");
            Console.WriteLine("     ------------------------------------------------\n" +
                "Made by Poko\n" +
                "\n" +
                "\n" +
                "\n" +
                "--- How to Use ---\n" +
                "- Choose whether to include each dlc pack\n" +
                "- Choose whether to generate assists\n" +
                "- Let the program do the rest :)\n" +
                "- Enjoy your new FighterZ team!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            Console.Clear();

            // Ask about all DLC's
            do
            {
                Console.WriteLine("Include all DLC packs at once? (If no, will ask for each pack individually)");
                Console.WriteLine();
                Console.WriteLine("Y: Yes");
                Console.WriteLine("N: No");
                Console.WriteLine();
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y" || userInput == "yes" || userInput == "Yes")
                {
                    DLC1 = true;
                    DLC2 = true;
                    DLC3 = true;

                    includeQuestion = false;
                }
                else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "No")
                {
                    AskDLC();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I didn't quite catch that, please try again!");
                    Console.WriteLine();
                }
            } while (includeQuestion);

            Console.Clear();
            includeQuestion = true;

            // Ask about assists
            do
            {
                Console.WriteLine("Generate an assist type with each character?");
                Console.WriteLine();
                Console.WriteLine("Y: Yes");
                Console.WriteLine("N: No");
                Console.WriteLine();
                userInput = Console.ReadLine();

                if (userInput == "Y" || userInput == "y" || userInput == "yes" || userInput == "Yes")
                {
                    assists = true;

                    includeQuestion = false;
                }
                else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "No")
                {
                    assists = false;

                    includeQuestion = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I didn't quite catch that, please try again!");
                    Console.WriteLine();
                }
            } while (includeQuestion);


            // Generate everything
            GenerateCharacters();

            
            Console.Clear();
            Console.WriteLine("Generating Team with the following settings: ");
            Console.WriteLine();
            Console.WriteLine("DLC1:        " + DLC1);
            Console.WriteLine("DLC2:        " + DLC2);
            Console.WriteLine("DLC3:        " + DLC3);
            Console.WriteLine("Assists:     " + assists);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Results");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Character 1:     " + character1);
            Console.WriteLine();
            Console.WriteLine("Character 2:     " + character2);
            Console.WriteLine();
            Console.WriteLine("Character 3:     " + character3);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to exit program.");

            Console.ReadLine();


            // If didn't set all DLC's at once, ask individually
            void AskDLC()
            {
                Console.Clear();

                // Ask about DLC 1
                do
                {
                    Console.WriteLine("Include DLC pack 1?");
                    Console.WriteLine();
                    Console.WriteLine("Y: Yes");
                    Console.WriteLine("N: No");
                    Console.WriteLine();
                    userInput = Console.ReadLine();

                    if (userInput == "Y" || userInput == "y" || userInput == "yes" || userInput == "Yes")
                    {
                        DLC1 = true;

                        includeQuestion = false;
                    }
                    else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "No")
                    {
                        DLC1 = false;

                        includeQuestion = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I didn't quite catch that, please try again!");
                        Console.WriteLine();
                    }
                } while (includeQuestion);

                Console.Clear();
                includeQuestion = true;

                // Ask about DLC 2
                do
                {
                    Console.WriteLine("Include DLC pack 2?");
                    Console.WriteLine();
                    Console.WriteLine("Y: Yes");
                    Console.WriteLine("N: No");
                    Console.WriteLine();
                    userInput = Console.ReadLine();

                    if (userInput == "Y" || userInput == "y" || userInput == "yes" || userInput == "Yes")
                    {
                        DLC2 = true;

                        includeQuestion = false;
                    }
                    else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "No")
                    {
                        DLC2 = false;

                        includeQuestion = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I didn't quite catch that, please try again!");
                        Console.WriteLine();
                    }
                } while (includeQuestion);

                Console.Clear();
                includeQuestion = true;

                // Ask about DLC 3
                do
                {
                    Console.WriteLine("Include DLC pack 3?");
                    Console.WriteLine();
                    Console.WriteLine("Y: Yes");
                    Console.WriteLine("N: No");
                    Console.WriteLine();
                    userInput = Console.ReadLine();

                    if (userInput == "Y" || userInput == "y" || userInput == "yes" || userInput == "Yes")
                    {
                        DLC3 = true;

                        includeQuestion = false;
                    }
                    else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "No")
                    {
                        DLC3 = false;

                        includeQuestion = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I didn't quite catch that, please try again!");
                        Console.WriteLine();
                    }
                } while (includeQuestion);

                Console.Clear();
            }


            // Generates characters
            void GenerateCharacters()
            {
                // A list of all selectable characters
                List<string> allCharacters = new List<string>();

                // A list of every character esult, so we don't get the same character
                List<int> characterResults = new List<int>();

                // If it is the same result, rerollCharacter is true
                bool rerollCharacter = false;

                // Add base game characters to the list
                allCharacters.AddRange(fighters);

                // Add all the dlc characters to the list
                if (DLC1)
                {
                    allCharacters.AddRange(dlcFighters1);
                }
                if (DLC2)
                {
                    allCharacters.AddRange(dlcFighters2);
                }
                if (DLC3)
                {
                    allCharacters.AddRange(dlcFighters3);
                }


                // Generate everything including Assists if enabled
                for (int i = 0; i < 3; i++)
                {
                    randomNumber = rnd.Next(1, 4);

                    // Assists
                    switch (i)
                    {
                        case 0:
                            switch (randomNumber)
                            {
                                case 1:
                                    assist1 = 'A';
                                    break;

                                case 2:
                                    assist1 = 'B';
                                    break;

                                case 3:
                                    assist1 = 'C';
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case 1:
                            switch (randomNumber)
                            {
                                case 1:
                                    assist2 = 'A';
                                    break;

                                case 2:
                                    assist2 = 'B';
                                    break;

                                case 3:
                                    assist2 = 'C';
                                    break;

                                default:
                                    break;
                            }
                            break;

                        case 2:
                            switch (randomNumber)
                            {
                                case 1:
                                    assist3 = 'A';
                                    break;

                                case 2:
                                    assist3 = 'B';
                                    break;

                                case 3:
                                    assist3 = 'C';
                                    break;

                                default:
                                    break;
                            }
                            break;

                        default:
                            break;
                    }

                    do
                    {
                        randomNumber = rnd.Next(1, allCharacters.Count);

                        // Compare result
                        if (i != 0)
                        {
                            if (randomNumber == characterResults[(i - 1)])
                            {
                                rerollCharacter = true;
                            }
                            else
                            {
                                rerollCharacter = false;
                            }
                        }

                        // Add the result to the list
                        characterResults.Add(randomNumber);
                    } while (rerollCharacter);

                    // Characters
                    switch (i)
                    {
                        case 0:
                            if (assists)
                                character1 = (allCharacters[randomNumber] + " - " + assist1 + " assist");
                            else
                                character1 = (allCharacters[randomNumber]);
                            break;

                        case 1:
                            if (assists)
                                character2 = (allCharacters[randomNumber] + " - " + assist2 + " assist");
                            else
                                character2 = (allCharacters[randomNumber]);
                            break;

                        case 2:
                            if (assists)
                                character3 = (allCharacters[randomNumber] + " - " + assist3 + " assist");
                            else
                                character3 = (allCharacters[randomNumber]);
                            break;


                        default:
                            break;
                    }
                }
            }
        }
    }
}
