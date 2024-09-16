using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._09
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
             // Příklad vstupu: "1,1,1"

            int sum = 0;
            for (int i = 0; i< input.Length; i++)
            
            {
                //převod aktuálního znaku na celé číslo
                int.TryParse(input[i].ToString(), out int value);
                sum += value;
            }
            // Výpis výsledného součtu na konzoli
            Console.WriteLine(sum);
            // Čekání na stisk klávesy
            Console.ReadKey();
        }
    }
}