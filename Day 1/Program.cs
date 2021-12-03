using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        private static void Main()
        {
            var listOfMeasurements = new int[] { 199,200,208,210,200,207,240,269,260,263 };

            var nr = 0;

            nrOfDeeperMeasurements(0, 1, listOfMeasurements, nr);
        }

        private static int nrOfDeeperMeasurements(int prevDeptIndex, int currDeptIndex, int[] measurments, int nrOfTimesDeeper)
        {
            if (currDeptIndex <= measurments.Length -1)
            {
                if (measurments[prevDeptIndex] < measurments[currDeptIndex])
                {
                    Console.WriteLine($"{measurments[currDeptIndex]} is deeper than {measurments[prevDeptIndex]}");
                    nrOfTimesDeeper++;
                }
                else
                {
                    Console.WriteLine($"{measurments[currDeptIndex]} is not deeper than {measurments[prevDeptIndex]}");
                }

                nrOfDeeperMeasurements(prevDeptIndex + 1, currDeptIndex + 1, measurments, nrOfTimesDeeper);
            }

            return nrOfTimesDeeper;
        }


    }
}
