using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            if (x >= 0 && x <= 432 && y >= 0 && y <= 468) Console.WriteLine("dentro");
            else Console.WriteLine("fora");

    }

}