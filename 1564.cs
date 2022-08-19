using System; 

class URI {

    static void Main(string[] args) { 

            string s = Console.ReadLine();
            int N;

            while (s != null)
            {
                N = int.Parse(s);

                if (N == 0) Console.WriteLine("vai ter copa!");
                else Console.WriteLine("vai ter duas!");

                s = Console.ReadLine();
            }

    }

}