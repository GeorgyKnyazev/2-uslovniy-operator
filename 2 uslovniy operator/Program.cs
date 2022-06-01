using System;

namespace _2_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyWord = "exit";
            string userInput ="";


            while (keyWord != userInput)
            {
                Console.WriteLine("Введите слово :");
                userInput = Console.ReadLine();
            }
            
        }
    }
}
