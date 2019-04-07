using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.Translate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            while (Console.ReadKey().Key==ConsoleKey.Escape)
            {
                Console.ResetColor();
                Console.WriteLine("Enter text :");
                string arm = Conv(Console.ReadLine());
                Console.WriteLine(arm); 
            }
        }

        static string Conv(string str)
        {
            StringBuilder builder = new StringBuilder(str);

            string[] lat = { "a", "b", "c", "d", "e" };
            string[] arm = { "ա", "բ", "ց", "դ", "ե" };


            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < lat.Length; j++)
                {
                    if (builder[i] == Convert.ToChar(lat[j]))
                        builder[i] = Convert.ToChar(arm[j]);

                }
            }


            return builder.ToString();

        }
    }
}
