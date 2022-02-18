using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakse kolm korda;
            //programm kuulutab võitja;


            Random rnd = new Random();

            int cpuScoreSUM = 0;
            int userScoreSUM = 0;

            int i = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Vajutage enter, oma käigu tegemiseks:");
                Console.ReadLine();

                int cpuRandom = rnd.Next(1, 7);
                int userRandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Teie viskasite {userRandom}.");

                cpuScoreSUM = cpuScoreSUM + cpuRandom;

                userScoreSUM = userScoreSUM + userRandom;
            }

            Console.WriteLine($"Arvuti viskas kokku: {cpuScoreSUM}");
            Console.WriteLine($"Kasutaja viskas kokku: {userScoreSUM}");

            if (cpuScoreSUM < userScoreSUM)
            {

                Console.WriteLine("Teie võit. Palju õnne!");
            }
            else if (cpuScoreSUM > userScoreSUM)
            {

                Console.WriteLine("Arvuti võitis teid, teinekord läheb äkki paremini.");
            }
            else
            {

                Console.WriteLine("Viik!");
            }



        }
    }
}
