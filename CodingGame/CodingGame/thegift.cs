using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class thegift
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[] budget = new int[N];
            for (int i = 0; i < N; i++)
            {
                budget[i] = int.Parse(Console.ReadLine());
            }
            budget = budget.OrderBy(x => x).ToArray();
            int remaining = N;

            if (budget.Sum(x => x) >= C)
            {
                for (int i = 0; i < N; i++)
                {
                    int avg = C / remaining;
                    if (budget[i] < avg)
                        C -= budget[i];
                    else
                        C -= avg;
                    Console.WriteLine((budget[i]<avg) ? budget[i] : avg);
                    remaining--;
                }
            }
            else
                Console.WriteLine("IMPOSSIBLE");

        }
    }
}
