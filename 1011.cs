using System; 

class URI {

    static void Main(string[] args) { 

            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = Math.Pow(radius, 3) * 3.14159 * 4/3;
            Console.WriteLine("VOLUME = {0:0.000}", volume);

    }

}