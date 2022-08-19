using System; 

class URI {

    static void Main(string[] args) { 

            int cases = int.Parse(Console.ReadLine());
            int pntA, pntB;
            string[] s = new string[2];
            int numA, numB;

            while (cases > 0)
            {
            pntA = 0;
            pntB = 0;

            for (int i = 0; i < cases; i++)
            {
                s = Console.ReadLine().Split(' ');
                numA = int.Parse(s[0]);
                numB = int.Parse(s[1]);

                if (numA > numB) pntA++;
                else if (numA < numB) pntB++;
            }

            Console.WriteLine($"{pntA} {pntB}");

            cases = int.Parse(Console.ReadLine());
            }

    }

}