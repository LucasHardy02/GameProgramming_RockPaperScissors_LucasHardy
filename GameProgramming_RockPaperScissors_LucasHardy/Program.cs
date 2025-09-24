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
        
        
        static ConsoleKeyInfo Answer;
        static string playerChoice;
        
        

        static void Main(string[] args)
        {
            int randomChoice = random.Next(3);

           
            //int valueOfChoice = int.Parse(myChoice);
            
            ShowHUD();
            Answer = Console.ReadKey(true);

            // Answer.Key

            if (ConsoleKey.D1 == Answer.Key)
            {
                Console.WriteLine("You Chose Rock.");
                playerChoice = "Rock";
            }
            else if (ConsoleKey.D2 == Answer.Key)
            {
                Console.WriteLine("You Chose Paper");
                playerChoice = "Paper";
            }
            else if (ConsoleKey.D3 == Answer.Key)
            {
                Console.WriteLine("You Chose Scissors");
                playerChoice = "Scissors";
            }
            

        }

        static void ShowHUD()
        {
            Console.WriteLine("Please Select Rock 1, Paper 2, or Scissors 3");
            
            
        }

        static void GameLogic()
        {
            




        }

        static void GameEnd()
        {
            if (win == true)
            {
                Console.WriteLine("You Win");
            }

            else if (lose == true)
            {
                Console.WriteLine("You Lose");
            }

           
        }

        static void GameTie()
        {
            Console.WriteLine("You Tied");
        }

    }

    //Players chooses
    //Computer chooses
    //Compares choices
    //if player wins then win
    //if player loses then lose
}
