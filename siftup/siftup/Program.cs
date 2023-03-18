using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siftup
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,1,3};
            int[] arr2 = solution(arr);
            foreach (int i in arr2)
                Console.WriteLine(i);
            
        }

        public static int[] solution(int[] arr)
        {
            int[] result = new int[] { };
            List<int> list = new List<int>();
            foreach (int n in arr)
            {
                if (arr.Count(x => x == n) == 1)
                    list.Add(n);
            }

            if (list.Count == 0)
            {
                list.Add(-1);
                result = list.ToArray();
            }
            else
                result = list.OrderBy(n => n).ToArray();

            return result;
        }
    }
}
