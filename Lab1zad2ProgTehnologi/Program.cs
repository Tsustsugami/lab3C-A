using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1zad2ProgTehnologi
{
    public class Logic
    {
        public static int[,] OutTable()
        {
            int [,]arrayOfTable = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    arrayOfTable[i, j] = i * j;
                }
            }
            return arrayOfTable;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("таблица умножения:");

            var Table=Logic.OutTable();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(Table[i, j]);
                    if (Table[i, j] < 10)
                    {
                        Console.Write(" | ");
                    }
                    else if (Table[i, j] >= 10)
                    {
                        Console.Write("| ");
                    }
                }
            }
        }
    }
}