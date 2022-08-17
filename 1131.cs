using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = new string[2];
            int I = 0;
            int i;
            int G = 0;
            int g;
            int E = 0;
            int redo;

            do
            {
                s = Console.ReadLine().Split(' ');
                i = int.Parse(s[0]);
                g = int.Parse(s[1]);

                if (i > g) I++;
                else if (i < g) G++;
                else E++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                redo = int.Parse(Console.ReadLine());
            } while (redo == 1);

            Console.WriteLine($"{I+G+E} grenais");
            Console.WriteLine($"Inter:{I}");
            Console.WriteLine($"Gremio:{G}");
            Console.WriteLine($"Empates:{E}");

            if (I > G) Console.WriteLine("Inter venceu mais");
            else if (G > I) Console.WriteLine("Gremio venceu mais");
            else Console.WriteLine("Nao houve vencedor");

    }

}