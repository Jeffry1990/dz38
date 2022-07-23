using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingMultipleNumber = 100;
            int endingMultipleNumber = 999;
            int randomMinNumber = 1;
            int randomMaxNumber = 28;
            Random random = new Random();
            int randomNumber = random.Next(randomMinNumber, randomMaxNumber);
            int targetNumbersCounter = 0;

            Console.WriteLine("Случайное число: " + randomNumber);
                

            for (int i = 0; i <= endingMultipleNumber; i += randomNumber)
            {
                if (i<=endingMultipleNumber && i>=startingMultipleNumber)
                {
                    targetNumbersCounter++;
                }
            }
            Console.WriteLine(targetNumbersCounter);
        }
    }
}
