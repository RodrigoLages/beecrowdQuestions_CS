using System; 

class URI {

    static void Main(string[] args) { 

            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 10000; i+=num)
            {
                Console.WriteLine(i);
            }

    }

}