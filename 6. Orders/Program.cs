namespace _6._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            PrintOrder(product, quantity);

            static void PrintOrder (string product, int quantity)
            {
                double coffeePrice = 1.50;
                double waterPrice = 1.00;
                double cokePrice = 1.40;
                double snacksPrice = 2.00;

                double sum = 0;

                if (product == "coffee")
                {
                    sum = quantity * coffeePrice;
                }
                else if (product == "water")
                {
                    sum = quantity * waterPrice;
                }
                else if (product == "coke")
                {
                    sum = quantity * cokePrice;
                }
                else if (product == "snacks")
                {
                    sum = quantity * snacksPrice;
                }
                Console.WriteLine($"{sum:f2}");
            }
        }
    }
}
