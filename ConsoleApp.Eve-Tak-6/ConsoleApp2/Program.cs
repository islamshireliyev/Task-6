using System;

namespace ConsoleApp2

{/*
  1)  Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string word = "Microsoft Visual Studio  programs:  ";
            int countA = 0;
            int countB = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    countA++;
                }
                else if (word[i] == 'b')
                {
                    countB++;
                }

            }
            double cavab = countA * 1.0 / countB;
            Console.WriteLine(countA);
            Console.WriteLine(countB);
            Console.WriteLine(cavab);
        }
    }
} 
