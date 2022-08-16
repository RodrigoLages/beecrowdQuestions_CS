using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            float gd1 = float.Parse(s[0]);
            float gd2 = float.Parse(s[1]);
            float gd3 = float.Parse(s[2]);
            float gd4 = float.Parse(s[3]);
            float gd5;

            float avg = (2*gd1 + 3*gd2 + 4*gd3 + gd4) / 10;
            Console.WriteLine("Media: {0:0.0}", Math.Round(avg, 1));

            if (avg < 5) Console.WriteLine("Aluno reprovado.");
            
            else if (avg >= 7) Console.WriteLine("Aluno aprovado.");

            else
            {
                Console.WriteLine("Aluno em exame.");
                gd5 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:0.0}", gd5);
                avg = (avg + gd5) / 2;

                if (avg < 5) Console.WriteLine("Aluno reprovado.");
                else Console.WriteLine("Aluno aprovado.");

                Console.WriteLine("Media final: {0:0.0}", Math.Round(avg, 1));
            }

    }

}