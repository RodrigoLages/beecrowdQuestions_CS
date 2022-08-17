using System; 

class URI {

    static void Main(string[] args) { 

            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i+=2)
            {
                Console.WriteLine($"{i}^2 = {i*i}");
            }

    }

}