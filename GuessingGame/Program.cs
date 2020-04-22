using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bell's Guessing Game");
            Console.WriteLine("There are three levels:");
            Console.WriteLine("1. Easy: Guess between 1 - 10, You get 6 guesses");
            Console.WriteLine("2. Medium: Guess between 1 - 20, You get 4 guesses");
            Console.WriteLine("3. Hard: Guess between 1 - 50, You get 3 guesses");

            //To minimize errors, users will input the number corresponding to a level
            int level = 0;
            Console.Write("Input the number in front of the chosen level (1, 2 or 3): ");
            level = int.Parse(Console.ReadLine()); Console.WriteLine();

            //Based on the number input above, the level name, number of tries and numberset are determined
            //An error message displays if input isn't valid
            int tries = 0;
            int numberset = 0;
            string levelname = "";

            if (level == 1) {
                levelname = "Easy";
                tries = 6;
                numberset = 10;
            }
            else if (level == 2) {
                levelname = "Medium";
                tries = 4;
                numberset = 20;
            }
            else if (level == 3) {
                levelname = "Hard";
                tries = 3;
                numberset = 50;
            }
            else {
                Console.WriteLine("Your input isn't correct");
            }

            //Displays level name, number of tries and numberset as set by the conditionals above
            Console.WriteLine("You have picked " + levelname + "!");
            Console.WriteLine("You have " + tries + " tries to guess the correct number from 1 to " + numberset);
            Console.WriteLine("Begin!"); Console.WriteLine();
            
            //The correct guess is randomnly selected from the relevant number set. 
            //The max value for Random().Next() is exclusive, so 1 is added to the numberset value
            int correctGuess = new Random().Next(1,numberset+1);
            int userGuess = 0;

            //For loop is limited to the number of tries for the level
            for (int i = 1; i <= tries; i++)
            {
                //The number of tries remaining is calculated as the number of tries minus the index of the current iteration
                int remainingTries = tries - i;
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());

                //Messages are displayed to show user if guess is correct or wrong with the number of tries remaining stated afterwards
                //A break statement is used to end the loop if user's guess is correct
                //If no more tries are available, the user is informed and the correct answer displayed

                if (userGuess == correctGuess) {
                    Console.WriteLine("You got it right!");
                    Console.WriteLine("Guesses remaining: "+ remainingTries); Console.WriteLine();
                    break;
                }

                else if (userGuess != correctGuess && i < tries) {
                    Console.WriteLine("That was wrong");
                    Console.WriteLine("Guesses remaining: "+ (remainingTries)); Console.WriteLine();
                }
                
                else {
                    Console.WriteLine("That was wrong. You have used up all your guesses."); Console.WriteLine();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("The correct answer was " + correctGuess);
                }
            }
        }
    }
}
