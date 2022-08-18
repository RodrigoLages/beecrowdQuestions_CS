using System; 

class URI {

    static void Main(string[] args) { 

            int size = int.Parse(Console.ReadLine());
            int[] fib = new int[size];
            string fibString = "0";
            fib[0] = 0;

            if (size > 1) fib[1] = 1;

            for (int i = 1; i < size-1; i++) fib[i+1] = fib[i] + fib[i-1];

            for (int i = 1; i < size; i++)
            {
                fibString += ' ';
                fibString += fib[i];
            }

            Console.WriteLine(fibString);

    }

}