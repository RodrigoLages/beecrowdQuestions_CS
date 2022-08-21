using System; 

class URI {

        static bool ChecarCPF(int[] nums, int[] dg)
        {
            for (int N = 0; N < 2; N++)
            {
                int sum = 0;
                int ct = 1;
                int o = 1;
                if (N == 1)
                {
                    ct = 9;
                    o = -1;
                }

                foreach (int num in nums)
                {
                    sum += num * ct;
                    ct += o;
                }

                int R = sum % 11;
                
                if (R == 10 && dg[N] == 0) continue;
                else if (dg[N] == R) continue;
                else return false;
            }
                return true;
        }
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            
            while (t != null)
            {
                string[] s = t.Split('-');
                int[] nums = new int[9];

                int i = 0;
                foreach (char c in s[0])
                {
                    if (c == '.') continue;
                    nums[i] = int.Parse(c.ToString());
                    i++;
                }

                int[] dg = new int[2];
                dg[0] = int.Parse(s[1][0].ToString());
                dg[1] = int.Parse(s[1][1].ToString());
            
                if (ChecarCPF(nums, dg)) Console.WriteLine("CPF valido");
                else Console.WriteLine("CPF invalido");

                t = Console.ReadLine();
            }
            
        }

}