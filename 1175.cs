using System; 

class URI {

    static void Main(string[] args) { 

            string[] V = new string[20];

            for (int i = 0; i < 20; i++) V[i] = Console.ReadLine();

            for (int i = 0; i < 20; i++) Console.WriteLine($"N[{i}] = {V[19 - i]}");

    }

}