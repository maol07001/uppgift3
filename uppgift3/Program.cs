using System;

namespace uppgift_3._3
{
    class Program
    {
        static void Main()
        {
            int timAvgift = 80;
            int maxDagAvgift = 950;

            Console.Write("Hur många timmar vill du hyra bilen? ");
            int timmar = int.Parse(Console.ReadLine());
            //kosnaden är timmarna gånger timavgiften
            int kostnad = timmar * timAvgift;
            //ifall kosnaden är större än maxdagavgiften kommer kosnaden vara lika med maxdagavgiften.
            if (kostnad > maxDagAvgift)
            {
                kostnad = maxDagAvgift;
            }

            Console.WriteLine("Kostnaden för att hyra bilen är " + kostnad + " kr.");
        }
    }
}