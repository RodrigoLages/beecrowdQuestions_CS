using System; 

class URI {

    static void Main(string[] args) { 

            string op = Console.ReadLine();
            float[,] M = new float[12, 12];
            float sum = 0;
            float num;

           for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    num = float.Parse(Console.ReadLine());

                    M[i, j] = num;
                    if (i + j < 11) sum += num;
                }
            }

            if (op == "M") Console.WriteLine("{0:0.0}", sum / 66);
            else Console.WriteLine("{0:0.0}", sum);

    }

}