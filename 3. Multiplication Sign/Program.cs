namespace _3._Multiplication_Sign
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
                int multipl = num1 * num2 * num3;

                if (multipl > 0)
                {
                    Console.WriteLine($"positive");
                }
                else if (multipl < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("zero");
                }
            }
        }
    }
}
