using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpRPS
{
    // 1 - rock
    // 2 - paper
    // 3- scissors
    public class ComputerPlayer
    {
        public int choice;
        public int Choice
        {
            get
            {
                return this.choice;
            }
            set
            {
                Random rand = new Random();
                int randNum = rand.Next(1, 4);
                this.choice = randNum;
            }
        }
    }
    
    class Program
    {
        public static char restart;
        static void Main(string[] args)
        {
            
            do
            {
                //var input = Console.ReadLine();
                //var num = Convert.ToInt32(input);
                //Console.WriteLine($"echo: {num}");
                //var player = new ComputerPlayer();
                //choose option
                //Console.WriteLine(player.Choice);
                Console.Write("Rock, Paper, Scissors! Choose with 'R', 'P', 'S': ");
                var input = Console.ReadLine();
                var chararacter = Convert.ToChar(input);
                if (chararacter == 'R')
                {
                    Console.WriteLine("You chose Rock");
                }
                if (chararacter == 'P')
                {
                    Console.WriteLine("You chose Paper");
                }
                if (chararacter == 'S')
                {
                    Console.WriteLine("You chose Scissors");
                }
                Random rand = new Random();
                int randNum = rand.Next(1, 4);
                //Console.WriteLine(randNum);
                //concat user string + randnum = cases
                string gameValue = randNum.ToString() + chararacter;
                //Console.WriteLine(gameValue);
                // ... Switch on the string.
                switch (gameValue)
                {
                    case "1R":
                        Console.WriteLine("Rock ties Rock!");
                        break;
                    case "2R":
                        Console.WriteLine("Paper beats Rock, you lose!");
                        break;
                    case "3R":
                        Console.WriteLine("Rock beats Scissors, you win!");
                        break;
                    case "1P":
                        Console.WriteLine("Paper covers Rock, you win!");
                        break;
                    case "2P":
                        Console.WriteLine("Paper vs Paper... Tie!");
                        break;
                    case "3P":
                        Console.WriteLine("Scissors cut Paper, you lose!");
                        break;
                    case "1S":
                        Console.WriteLine("Rock smashed Scissors, you lose!");
                        break;
                    case "2S":
                        Console.WriteLine("Scissors cut Paper, you win!");
                        break;
                    case "3S":
                        Console.WriteLine("Scissors and Scissors... Tie!");
                        break;
                }



                Console.WriteLine("Run again? y/n");
                restart = Convert.ToChar(Console.ReadLine());
            } while (restart == 'y');

            
        }
    }
}
