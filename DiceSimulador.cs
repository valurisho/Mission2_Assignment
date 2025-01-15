namespace Mission2_Assignment;

public class DiceSimulador
{
    public int[] GenerateNum(int num)
    {
        Random random = new Random();

        int[] numbersArray = new int[11];
        
        for (int i = 0; i < num; i++)
        {
            // Generate a random dice roll between 1 and 6
            int firstrandom = random.Next(1, 7);
            int secondrandom = random.Next(1, 7);
            
            int randomtotal = firstrandom + secondrandom;
            numbersArray[randomtotal - 2] += 1;
        }

        return numbersArray;
    }
    
}