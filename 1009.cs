using System; 

class URI {

    static void Main(string[] args) { 

            Console.ReadLine();
            double sallary = Convert.ToDouble(Console.ReadLine());
            double sales = Convert.ToDouble(Console.ReadLine());
            double bonus = 3 * sales / 20;
            Console.WriteLine("TOTAL = R$ {0:0.00}", sallary + bonus);

    }

}