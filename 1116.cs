using System; 

class URI {

    static void Main(string[] args) { 

            int cases = int.Parse(Console.ReadLine());
            string[] s = new string[2];
            float x;
            int y;

            for (int i = 0; i < cases; i++)
            {
                s = Console.ReadLine().Split(' ');
                x = float.Parse(s[0]);
                y = int.Parse(s[1]);

                if (y == 0) Console.WriteLine("divisao impossivel");
                else Console.WriteLine("{0:N1}", x/y);
            }

    }

}