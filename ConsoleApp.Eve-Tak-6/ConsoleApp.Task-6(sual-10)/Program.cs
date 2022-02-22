using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp.Task_6_sual_10_
{/*
  
10) Verilmish metinde butun reqemleri legv et.

  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int[] numCharCodes = Enumerable.Range(48, 10).ToArray();


            string metn = "-10)Verilmish metinde 32 butun reqemleri legv et.";
            string newText = " ";

            for (int i = 0; i < metn.Length; i++)
            {
                byte charCode = (byte)metn[i];

                if (Array.IndexOf(numCharCodes, charCode) == -1)
                    newText = newText + metn[i];
            }
            Console.WriteLine(metn);
            Console.WriteLine(newText);
        }
    }
}
