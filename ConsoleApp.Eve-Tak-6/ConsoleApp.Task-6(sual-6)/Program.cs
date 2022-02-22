using System;
using System.Text;

namespace ConsoleApp.Task_6_sual_6_
{/*
  6)  Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word = "Microsoft Visual Studio  computer programs";
            char[] symbols = { 'a' };
            if (true)
            {

            
            int index = word.IndexOfAny(symbols);
            Console.WriteLine(index);

            char[] symbol = { 'a' };
            int indexs = word.LastIndexOfAny(symbol);
            Console.WriteLine(indexs);
            
            }

        }
    }
}
