using System;
using System.Text;

namespace ConsoleApp1.Task_6_Sual_2_
{/*
  2)  Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
  */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            char a = 'x';
            string metn = "Microsoft Visual Studio  computer programs:  ";

            bool okey = true;
            for (int i = 0; i < metn.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (metn[i]==a)
                    {
                        okey = false;
                        break;
                    }
                }
              
            }
            Console.WriteLine();
            if (okey = true)
            {
                Console.WriteLine("dogrudur");
            }
            
        }
    }
}
