using System; 

class URI {

    static void Main(string[] args) { 

            int num;
            int high = -1;
            int pos = -1;
            for (int i = 1; i <= 100; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > high)
                {
                    high = num;
                    pos = i;
                }
            }

            Console.WriteLine(high);
            Console.WriteLine(pos);

    }

}