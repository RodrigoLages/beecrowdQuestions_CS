using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beecrowdQuestions_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notes = { 10000, 5000, 2000, 1000, 500, 200 };
            float[] coins = { 100, 50, 25, 10, 5, 1 };
            float money = Convert.ToSingle(Console.ReadLine());
            money *= 100;

            Console.WriteLine("NOTAS:");
            foreach (int note in notes)
            {
                Console.WriteLine("{0} nota(s) de R$ {1:N2}", (int)(money / note), note / 100);
                money = money % note;
            }

            Console.WriteLine("MOEDAS:");
            foreach (float coin in coins)
            {
                Console.WriteLine("{0} moeda(s) de R$ {1:N2}", (int)(money / coin), coin / 100);
                money = money % coin;
            }
        }
    }
}
