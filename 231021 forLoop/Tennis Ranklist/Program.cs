using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int pointsWon = 0;
            int tournamentsWon = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    pointsWon += 2000;
                    tournamentsWon++;
                }
                else if (result == "F")
                {
                    pointsWon += 1200;
                }
                else if (result == "SF")
                {
                    pointsWon += 720;
                }
            }
            Console.WriteLine($"Final points: {startPoints + pointsWon}");
            int averagePoints = pointsWon / tournamentsCount;
            Console.WriteLine($"Averge points: {averagePoints}");
            double percentageTournamentsWon = (double)tournamentsWon / tournamentsCount * 100;
            Console.WriteLine($"{percentageTournamentsWon}%");

        }
    }
}
