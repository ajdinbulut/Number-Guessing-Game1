using System;

namespace Number_Guessing_Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Please enter a number between 0 and 100: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int randNum = r.Next(0,100);
           while(userInput != randNum)
            {
                if(userInput > randNum)
                {
                    Console.WriteLine("Too high!");
                }else if(userInput < randNum)
                {
                    Console.WriteLine("Too low!");
                }

                userInput = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Correct!"); 

        }
    }
}
