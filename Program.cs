using System;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           
          Random numberGen = new Random();

           int roll1 = 0;
           int roll2 = 1;
           int attempts = 0;
           
          Console.WriteLine("Check out how many attempts it takes before You roll two dice of a kind." + "\n" + "Press some key to roll the dice");

            while (roll1 != roll2){
             Console.ReadKey();
             roll1 = numberGen.Next(1, 7);
             roll2 = numberGen.Next(1, 7);
             Console.WriteLine("You rolled: " + roll1);
             Console.WriteLine("You rolled: " + roll2 + "\n");
             attempts++;
            }
           Console.WriteLine("It took you: " + attempts + " attempts to roll 6" );


            // Wait before closing
           Console.ReadKey();
        }
    }
}
