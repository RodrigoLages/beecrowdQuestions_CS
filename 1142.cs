using System; 

class URI {

    static void Main(string[] args) { 

            int cases = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine($"{num} {num+1} {num+2} PUM");
                num += 4;
            }

    }

}