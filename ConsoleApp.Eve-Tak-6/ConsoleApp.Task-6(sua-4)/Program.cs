using System;
using System.Text;

namespace ConsoleApp.Task_6_sua_4_
{/*
  4)  Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            string word = "Microsoft Visual Studio  computer programs";

            char[] symbols = { 'a' };
            int index = word.LastIndexOfAny(symbols);
            Console.WriteLine(index);
            while (index%2!=0)
            {
                Console.WriteLine("tekdir");
                return;
            }
        }
    }
}
