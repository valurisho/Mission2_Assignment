// See https://aka.ms/new-console-template for more information

using Mission2_Assignment;
using static System.Console;

public class Program
{
    private static void Main(string[] args)
    {
        
        DiceSimulador ds = new DiceSimulador();
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int numRolls = int.Parse(Console.ReadLine());

        int[] rolls = ds.GenerateNum(numRolls);
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls);
        
        int[] rollPercent = new int[11];
        
        for (int i = 0; i < rolls.Length; i++)
        { 
            double percentage = ((double)rolls[i] / numRolls) * 100;
            rollPercent[i] = (int)Math.Round(percentage);
        }

        for (int i = 0; i < rollPercent.Length; i++)
        {
            int count = rollPercent[i];
            string stars = new string('*', count);
            Console.WriteLine($"{i+2}: {stars}");
        }
        
        
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}