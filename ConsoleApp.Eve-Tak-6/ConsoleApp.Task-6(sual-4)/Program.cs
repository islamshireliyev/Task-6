using System;
using System.Text;

namespace ConsoleApp.Task_6_sual_5_
{/*
  5)  Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan  hansi birinci gelir?
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word= "Microsoft Visual Studio  computer programs";
            char[] symbols = { 'a', 'b', 'c' };

            
            int index=word.IndexOfAny(symbols);
            Console.WriteLine(index);

        }
    }
}
