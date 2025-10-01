using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GameProgramming_RockPaperScissors_LucasHardy
{
    internal class Program
    {

        static string[] gameOptions = { "Rock", "Paper", "Scissors" };
        static Random random = new Random();
        static bool win = false;
        static bool lose = false;
        static int numberOfWins = 0;
        static int numberOfComputerWins = 0;
        
        static ConsoleKeyInfo Answer;
        static string playerChoice;
        static string computerChoice;
        

        static void Main(string[] args)
        {
            int randomChoice = random.Next(3);


            computerChoice = gameOptions[randomChoice];
            while (numberOfWins < 3 && numberOfComputerWins < 3)
            {
                win = false;
                lose = false;
                ShowHUD();
                Answer = Console.ReadKey(true);
                GameLogic();
                CompareChoices();
                Console.ReadKey(true);
                Console.WriteLine($"You have {numberOfWins} wins!");
                Console.WriteLine($"Computer has {numberOfComputerWins} wins!");
                Console.ReadKey(true);
                Console.Clear();
                if (numberOfComputerWins == 3 && numberOfWins < numberOfComputerWins)
                {
                    Console.WriteLine("You Lose best 2 out of 3!");
                }
            }
            
            
        }

        static void ShowHUD()
        {
            Console.WriteLine("Please Select Rock 1, Paper 2, or Scissors 3");
            
            
        }

        static void GameLogic()
        {
            bool validChoice = false;

            while (!validChoice)
            {
                if (ConsoleKey.D1 == Answer.Key)
                {
                    Console.WriteLine("You Chose Rock.");
                    playerChoice = gameOptions[0];
                    validChoice = true;
                }
                else if (ConsoleKey.D2 == Answer.Key)
                {
                    Console.WriteLine("You Chose Paper");
                    playerChoice = gameOptions[1];
                    validChoice = true;

                }
                else if (ConsoleKey.D3 == Answer.Key)
                {
                    Console.WriteLine("You Chose Scissors");
                    playerChoice = gameOptions[2];
                    validChoice = true;

                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    Answer = Console.ReadKey(true);
                }

            }







        }

        static void GameEnd()
        {
            if (win == true)
            {
                Console.WriteLine("You Win");
                numberOfWins = numberOfWins + 1;
            }

            else if (lose == true)
            {
                Console.WriteLine("You Lose");
                numberOfComputerWins = numberOfComputerWins + 1;
            }

           
        }

        static void GameTie()
        {
            if (computerChoice == playerChoice)
            Console.WriteLine("You Tied");
        }

        static void CompareChoices()
        {
            if (computerChoice == playerChoice)
            {
                GameTie();

            }

            else if (computerChoice == "Rock" && playerChoice == "Paper")
            {
                Console.WriteLine("You beat Computers Rock with your Paper");
                win = true;
                GameEnd();
            }
            else if (computerChoice == "Rock" && playerChoice == "Scissors")
            {
                Console.WriteLine("Computers Rock beats your Scissors");
                lose = true;
                GameEnd();
            }

            else if (computerChoice == "Paper" && playerChoice == "Rock")
            {
                Console.WriteLine("Computers Paper beats your Rock");
                lose = true;
                GameEnd();
            }

            else if (computerChoice == "Paper" && playerChoice == "Scissors")
            {
                Console.WriteLine("You beat Computers Paper with your Scissors");
                win = true;
                GameEnd();
            }

            else if (computerChoice == "Scissors" && playerChoice == "Paper")
            {
                Console.WriteLine("Computers Scissors beats your paper");
                lose = true;
                GameEnd();
            }
            else if (computerChoice == "Scissors" && playerChoice == "Rock")
            {
                Console.WriteLine("You beat Computers Scissors with your Rock");
                win = true;
                GameEnd();
            }

        }
    }

   
}
