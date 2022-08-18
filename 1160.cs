using System; 

class URI {

    static void Main(string[] args) { 

            int cases = int.Parse(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double pA = int.Parse(s[0]);
                double pB = int.Parse(s[1]);
                double gA = double.Parse(s[2]);
                double gB = double.Parse(s[3]);
                int years = 0;

                while (pA <= pB && years <= 100)
                {
                    pA = Math.Floor(pA + pA * gA/100);
                    pB = Math.Floor(pB + pB * gB/100);
                    years++;
                }

                if (years > 100) Console.WriteLine("Mais de 1 seculo.");
                else Console.WriteLine($"{years} anos.");
            }

    }

}