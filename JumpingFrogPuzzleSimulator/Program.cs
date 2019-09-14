using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JumpingFrogPuzzleSimulator
{
    class Program
    {
        static readonly int numSimulations = 1000000000;
        static readonly int maxPossibleJumps = 100;
        static async Task Main(string[] args)
        {
            var jumpStats = new ConcurrentBag<JumpStat>();
            var taskList = new List<Task>();

            for (int numPossibleJumps = 2; numPossibleJumps <= maxPossibleJumps; numPossibleJumps++)
            {
                taskList.Add(DoSimulation(jumpStats, numPossibleJumps));
            }

            await Task.WhenAll(taskList);

            IOrderedEnumerable<JumpStat> orderedJumpStats = jumpStats.OrderBy(x => x.NumberOfPossibleJumps);

            foreach (var stat in orderedJumpStats)
            {
                Console.WriteLine("Number of possible jumps: " + stat.NumberOfPossibleJumps + " Average number of jumps: " + stat.AverageNumberOfJumps);
            }
        }

        static int Jump(int numPossibleJumps, int jumpsSoFar = 0)
        {
            if (numPossibleJumps == 1)
            {
                return jumpsSoFar + 1;
            }
            else if (numPossibleJumps == 0)
            {
                return jumpsSoFar;
            }
            int distanceJumped = ThreadLocalRandom.Next(1, numPossibleJumps + 1);
            return Jump(numPossibleJumps - distanceJumped, jumpsSoFar + 1);
        }

        static async Task DoSimulation(ConcurrentBag<JumpStat> jumpStats, int numPossibleJumps)
        {
            await Task.Run(() =>
            {
                long totalJumps = 0;
                for (int _ = 0; _ < numSimulations; _++)
                {
                    totalJumps += Jump(numPossibleJumps);
                }
                jumpStats.Add(new JumpStat()
                {
                    NumberOfPossibleJumps = numPossibleJumps,
                    AverageNumberOfJumps = (double)totalJumps / (double)numSimulations
                });
            });
        }
    }
}

