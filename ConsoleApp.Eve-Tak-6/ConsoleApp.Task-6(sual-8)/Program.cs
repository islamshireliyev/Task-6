using System;
using System.Text;

namespace ConsoleApp.Task_6_sual_8_
{/*
      8)  Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word = "Microsoft Visual Studio  computer programs";
            char[] symbols = { 'a' };
            int index = word.IndexOfAny(symbols);
            Console.WriteLine(index);
           word= word.Insert(14+1, "llllllllll");
            Console.WriteLine(word);
        }
    }
}
