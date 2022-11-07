using System;

namespace Lab1zad3ProgTehnologi
{
    public class Logic
    {
        public static float CalculatingPercentages(string sentence)
        {
            float numbersLetters=0;
            foreach (var symbol in sentence)
            {
                if (char.IsLetter(symbol))
                {
                    numbersLetters += 1;                  
                }
            }
            int numbersCharacters=sentence.Length;
            float Percentages=numbersLetters/numbersCharacters;
            return Percentages;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string sentence = Console.ReadLine();

            var Percentages = Logic.CalculatingPercentages(sentence);

            Console.WriteLine(Percentages*100+" % Букв в слове");
        }
    }
}