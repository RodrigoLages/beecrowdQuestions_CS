using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            int people = int.Parse(s[0]);
            int total = int.Parse(s[1]);
            int sheets = int.Parse(s[2]);

            if (people * sheets <= total) Console.WriteLine("S");
            else Console.WriteLine("N");

    }

}