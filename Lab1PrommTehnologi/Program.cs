namespace Lab1PrommTehnologi
{
    public class Logic
    {
        public static string Decision(int number)
        {
            int remains, maxremains = 0;
            string outMessage = "";
            for (int i = 0; i < 3; i++)
            {
                remains = number % 10;
                number = number / 10;
                if (maxremains<remains)
                {
                    maxremains = remains;
                }
            }
            outMessage = "Максимальная цифра в числе " + maxremains;
            return outMessage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число");
            int number = int.Parse(Console.ReadLine());

            var outMessage=Logic.Decision(number);

            Console.WriteLine(outMessage);
        }
    }
}