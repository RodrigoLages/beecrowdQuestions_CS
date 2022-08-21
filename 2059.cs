using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            bool even = Convert.ToBoolean(int.Parse(s[0]));
            int p1 = int.Parse(s[1]);
            int p2 = int.Parse(s[2]);
            bool cheat = Convert.ToBoolean(int.Parse(s[3]));
            bool caught = Convert.ToBoolean(int.Parse(s[4]));
            int winner;
            
            if (even && (p1+p2) % 2 == 0 || !even && (p1+p2) % 2 == 1) winner = 1;
            else winner = 2;

            if (cheat != caught) winner = 1;
            else if (cheat && caught) winner = 2;

            Console.WriteLine($"Jogador {winner} ganha!");

    }

}