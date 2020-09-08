using System;
using System.ComponentModel;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange fem heltal:");
            Console.WriteLine(Add(new int[5]));
            Console.WriteLine("Skriv fem stycken ord:");
            Console.WriteLine(ReverseWords(new string[5]));
            Console.WriteLine("Skriv fem heltal:");
            Compare(new int[5]);
        }

        private static int Add(int[] NumList1)
        {
            var sumOfAll = 0;
            
            for (int i = 0; i < NumList1.Length; i++)
            {
                var input = Console.ReadLine();
                NumList1[i] = int.Parse(input);
            }
            
            var firstSum = NumList1[0];
            var secondSum = NumList1[1];
            var thirdSum = NumList1[2];
            var fourthSum = NumList1[3];
            var fifthSum = NumList1[4];
            
            sumOfAll = firstSum + secondSum + thirdSum + fourthSum + fifthSum;
            
            return sumOfAll;
        }

        private static string ReverseWords(string[] WordsList)
        {

            for (int i = 0; i < WordsList.Length; i++)
            {
                WordsList[i] = Console.ReadLine();
            }
            
            for (int j = WordsList.Length - 1; j >= 0; j--)
            {
                 Console.WriteLine(WordsList[j]);
            }
            return " ";
        }
        
        private static void Compare(int[] NumList2)
        {
            for (int i = 0; i < NumList2.Length; i++)
            {
                var input = Console.ReadLine();
                NumList2[i] = int.Parse(input);
            }

            Array.Sort(NumList2);

            
            int greatest = NumList2[4];
            
            int lessest = NumList2[0];

            Console.WriteLine(greatest);
            Console.WriteLine(lessest);
        }
    }
}
