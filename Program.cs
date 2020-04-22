using System;

namespace Uc_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************  Welcome to UcWealth Lotto!  *****************");
            Console.WriteLine("**************************  It's Time to Get Rich Quick!  ***************");
            Console.WriteLine("**************************  Select the Level you want to play below: (Enter a number between 1 to 3) ");

            string[] levels = {"1) Easy", "2) Medium", "3) Hard", "4) Quit"};

            // Display the Level Options Menu
            Array.ForEach(levels, Console.WriteLine);
            string selectedOption = Console.ReadLine();

            int numOfGuesses; //Initialize number of guesses variable
            Random random = new Random(); //Initialize random number generator

            /* ========================== OPTION 1: EASY LEVEL OF DIFFICULTY ======================= */

            if (selectedOption == "1")
            {
                numOfGuesses = 6;
                int winningNumber = random.Next(1,10);

                Console.WriteLine("Welcome to the Easy Level.\nGuess a whole number between 1 - 10.\nYou have "+numOfGuesses+" Guesses!");
               
                for (int i = 0; i < 6; i++)              
                {
                    int numberPlayed = int.Parse(Console.ReadLine());
                    // Check if number entered is the same as the generated number
                    if (numberPlayed == winningNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT! \n\nYou just won yourself 10,000 Naira! You are a champion indeed!\n");
                        break;
                    }
                    else
                    {
                        numOfGuesses -= 1;

                        if(numOfGuesses > 1)
                        {
                            Console.WriteLine("Wrong! Try again! You have " + numOfGuesses + " guesses left");
                        } 
                        else if(numOfGuesses == 1)
                        {
                            Console.WriteLine("Wrong! You have only 1 guess left. Use it Well!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Again! You have run out of Guesses. YOU LOSE!\n\nThe Winning Number is " + winningNumber + "\n\nGAME OVER!!!");
                        }
                        

                    }
                }


            }
            /* ========================== OPTION 2: MEDIUM LEVEL OF DIFFICULTY =======================*/

            else if (selectedOption == "2")
            {
                numOfGuesses = 4;
                int winningNumber = random.Next(1, 20); //add a function that generates random numbers here

                Console.WriteLine("Welcome to the Medium Level.\nGuess a whole number between 1 - 20.\nYou have " + numOfGuesses + " Guesses!");

                for (int i = 0; i < 4; i++)
                {
                    int numberPlayed = int.Parse(Console.ReadLine());
                    // Check if number entered is the same as the generated number
                    if (numberPlayed == winningNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT! \n\nYou just won yourself 100,000 Naira! You are a champion indeed!\n");
                        break;
                    }
                    else
                    {
                        numOfGuesses -= 1;

                        if (numOfGuesses > 1)
                        {
                            Console.WriteLine("Wrong! Try again! You have " + numOfGuesses + " guesses left");
                        }
                        else if (numOfGuesses == 1)
                        {
                            Console.WriteLine("Wrong! You have only 1 guess left. Use it Well!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Again! You have run out of Guesses. YOU LOSE!\n\nThe Winning Number is " + winningNumber + "\n\nGAME OVER!!!");
                        }


                    }
                }

            }

            /* ========================== OPTION 3: HARD LEVEL OF DIFFICULTY =======================*/

            else if (selectedOption == "3")
            {
                numOfGuesses = 3;
                int winningNumber = random.Next(1, 50); //add a function that generates random numbers here

                Console.WriteLine("Welcome to the Hard Level.\nGuess a whole number between 1 - 50.\nYou have " + numOfGuesses + " Guesses!");

                for (int i = 0; i < 3; i++)
                {
                    int numberPlayed = int.Parse(Console.ReadLine());
                    // Check if number entered is the same as the generated number
                    if (numberPlayed == winningNumber)
                    {
                        Console.WriteLine("YOU GOT IT RIGHT! \n\nYou just won yourself a Million Naira! You are a champion indeed!\n");
                        break;
                    }
                    else
                    {
                        numOfGuesses -= 1;

                        if (numOfGuesses > 1)
                        {
                            Console.WriteLine("Wrong! Try again! You have " + numOfGuesses + " guesses left");
                        }
                        else if (numOfGuesses == 1)
                        {
                            Console.WriteLine("Wrong! You have only 1 guess left. Use it Well!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong Again! You have run out of Guesses. YOU LOSE!\n\nThe Winning Number is " + winningNumber+"\n\nGAME OVER!!!");
                        }


                    }
                }

            }
            else if (selectedOption == "4")
            {
                Console.WriteLine("You have Chosen to quit so fast! Bye...");
                Environment.Exit(0);
                              
            }
            else
            {
                Console.WriteLine("You entered an Invalid Option!");
            }
        }
    }
}
