﻿namespace _3._1_Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintSign(num1, num2, num3);

            static void PrintSign(int num1, int num2, int num3)
            {
                if (num1 == 0 || num2 == 0 || num3 == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (num1 > 0 && num2 > 0 && num3 > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (num1 < 0 && num2 < 0 && num3 > 0)
                {
                    Console.WriteLine("positive");
                }
                else if (num1 > 0 && num2 < 0 && num3 < 0)
                {
                    Console.WriteLine("positive");
                }
                else if (num1 < 0 && num2 > 0 && num3 < 0)
                {
                    Console.WriteLine("positive");
                }
                else 
                {
                    Console.WriteLine("negative");
                }
                
            }
        }
    }
}
