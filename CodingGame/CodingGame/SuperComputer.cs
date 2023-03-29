using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class SuperComputer
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] arr = new int[N][];

            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int J = int.Parse(inputs[0]);
                int D = int.Parse(inputs[1]);
                arr[i] = new int[] { J, J+D-1};
            }
            var sortedByFirst = arr.OrderBy(x => x[0]);
            var sortedBySecond = sortedByFirst.OrderBy(x => x[1]);
            int[][] sortedArr = sortedBySecond.ToArray();

            int day = sortedArr[0][1];
            int answer = 1;
            for (int i = 1; i < N; i++)
            {
                if (day < sortedArr[i][0])
                {
                    day = sortedArr[i][1];
                    answer++;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
