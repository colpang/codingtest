using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Ex_array_reverse
{
    class midvalue
    {

        static public int solution(int[] array)
        {
            Array.Sort(array);
            int result = array[array.Length/2];

            /* LINQ를 사용한 정렬을 통해서도 가능하다*/
            //OrderBy는 오름차순 정렬
            //내림차순 정렬을 하려면 OrderByDescending.
            // int result = array.OrderBy(x => x).ToArray()[array.Length/2];
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 7, 10, 11 };
            Console.WriteLine( solution(arr));
            printArr(arr);
        }

        static void printArr(int[] arr)
        {
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

    }
}
