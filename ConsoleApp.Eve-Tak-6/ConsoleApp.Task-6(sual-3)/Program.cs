using System;
using System.Text;

namespace ConsoleApp.Task_6_sual_3_
{/*
  3)  Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            char b = 'x';
            string metn = "Microsoft Visual Studio  computer programs:  ";

            bool okey = true;
            for (int i = 0; i < metn.Length; i++)
            {
                if (i%2==0)
                {
                    if (metn[i] == 0)
                    {
                        okey = false;
                        break;
                    }
                    Console.WriteLine(metn[i]);
                }
            }
            Console.WriteLine();
                if (okey = true)
                {
                Console.WriteLine("Beraberdir");
                }
        }
    }
}
