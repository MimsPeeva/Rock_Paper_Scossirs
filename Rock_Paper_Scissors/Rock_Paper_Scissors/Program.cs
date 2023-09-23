using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors");
            string playerMove = Console.ReadLine();
            if (playerMove == "r" || playerMove == "rock")
            { playerMove = Rock; }
            else if (playerMove == "p" || playerMove == "paper")
            { playerMove = Paper; }
            else if (playerMove == "s" || playerMove == "scissors")
            { playerMove = Scissors; }
            else { Console.WriteLine("Invalid Input. Try again..."); return; }
            Random random = new Random();
            int computerRandomMove = random.Next(1, 4);
            string computerMove = "";
            switch (computerRandomMove)
            {
                case 1: computerMove = Rock; break;
                case 2: computerMove = Paper; break;
                case 3: computerMove = Scissors; break;
            }
            Console.WriteLine($"The computer chose {computerMove}.");
            if ((computerMove == Rock && playerMove == Scissors) || (computerMove == Paper && playerMove == Rock) || (computerMove == Scissors && computerMove == Paper))
            { Console.WriteLine("The computer win."); }
            else if ((computerMove == Rock && playerMove == Rock) || (computerMove == Paper && playerMove == Paper) || (computerMove == Scissors && computerMove == Scissors))
                Console.WriteLine("This game was a draw.");
            else Console.WriteLine("You win.");
        }
    }
}
