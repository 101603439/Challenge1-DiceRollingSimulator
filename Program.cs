using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1; 
            int max = 7;   
            int min2 = 1; 
            int max2 = 7;   
 
            Random random = new Random();
            int Dice1= random.Next(min, max);
            int Dice2= random.Next(min2, max2);
 
            Console.WriteLine("Dice1 = " + Dice1);
            Console.WriteLine("Dice2 = " + Dice2);
            
            Console.ReadLine();

        }
    }
    
}
