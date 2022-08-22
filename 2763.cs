using System; 

class URI {

    static void Main(string[] args) { 

            string s = Console.ReadLine();

            for (int i = 0; i < 14; i++)
            {
                if (i % 4 == 3) Console.Write("\n");
                else Console.Write(s[i]);
            }
            Console.Write("\n");

    }

}