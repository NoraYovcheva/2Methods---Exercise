namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            // валидна дължина [6, 10]
            // валидната дължина връща true, a невалидната връща false
            bool isValidLength = password.Length >= 6 && password.Length <= 10;
            // валидно съдържание - съдържа само букви и цифри
            bool isValidContent = CheckContent(password);
            // валиден брой цифри >= 2
            bool isValidCountDigits = CheckCountDigits(password);
            if (isValidLength == true && isValidContent == true && isValidCountDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                //It should contain 6 – 10 characters (inclusive)
                if (isValidLength == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                //It should contain only letters and digits
                if (isValidContent == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                //It should contain at least 2 digits 
                if (isValidCountDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }

            static bool CheckContent(string password)
            {
                for (int possition = 0; possition <= password.Length - 1; possition++)
                {
                    char simbol = password[possition];

                    if (char.IsLetterOrDigit(simbol) == false)
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool CheckCountDigits (string password)
            {
                int count = 0;

                for (int possition = 0; possition <= password.Length - 1; possition++)
                {
                    char simbol = password[possition];

                    if (char.IsDigit(simbol) == true)
                    {
                        count++;
                    }
                }
                return count >= 2;
            }
        }
    }
}
