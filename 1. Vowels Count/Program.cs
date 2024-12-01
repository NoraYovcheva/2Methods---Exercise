namespace _1._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();

            Console.WriteLine(VowelsCount(text));

            static int VowelsCount (string text)
            {
                int count = 0;
                for (int possition = 0; possition <= text.Length - 1; possition++)
                {
                    char simbol = text[possition];
                    switch (simbol)
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'I':
                        case 'i':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u':
                            count++;
                            break;
                    }
                }
                return count;
            }
        }
    }
}
