using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandom = rnd.Next(1, 11);
            int answer = 11;
            Console.WriteLine("Try to guess my number! It is from 0 to 10 only!");
           
            while (answer != myRandom)
            {
                
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == myRandom)
                {
                    Console.WriteLine($"You are right, the answer is {answer}!");
                
                }
                else
                {
                    Console.WriteLine("WRONG! Just try again!");
                }
            }          


        }

    }
}