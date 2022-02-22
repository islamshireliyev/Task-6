using System;
using System.Text;

namespace ConsoleApp.Task_6_sual_12_
{/*
  12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word = "Microsoft Visual Studio  computer programs";


            word=word.Remove(1 ,word.Length - 2);
            Console.WriteLine(word);
        }
    }
}
