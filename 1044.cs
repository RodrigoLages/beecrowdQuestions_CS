using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            if (x % y == 0 || y % x == 0) Console.WriteLine("Sao Multiplos");
            else Console.WriteLine("Nao sao Multiplos"); 

    }

}