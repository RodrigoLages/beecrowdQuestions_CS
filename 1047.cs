using System; 

class URI {

    static void Main(string[] args) { 

            string[] s = Console.ReadLine().Split(' ');
            int Hi = int.Parse(s[0]);
            int Mi = int.Parse(s[1]);
            int Hf = int.Parse(s[2]);
            int Mf = int.Parse(s[3]);

            int minutes = Mf - Mi;
            int hours = Hf - Hi;

            if (minutes < 0)
            {
                minutes += 60;
                hours--;
            }

            if (hours < 0) hours += 24;

            if (Hi == Hf && Mi == Mf) hours = 24;

            Console.WriteLine($"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)");

    }

}