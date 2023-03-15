using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level0
{
    class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] origin = new int[] {1,2,4,8,6,9,10 };
            printArr(origin);

            //배열 뒤집기
            //1. Array.Reverse 함수 사용
            Array.Reverse(origin);
            printArr(origin);

            //2. 배열의 마지막부터 대입
            //배열의 길이나 문자열의 길이등은 Length. 대문자임
            int[] arr2 = new int[origin.Length];
            for(int i = 0; i < origin.Length; i++)
                arr2[i] = origin[origin.Length - 1 -i];
            printArr(arr2);
        }

        static void printArr(int[] arr)
        {
            foreach(int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
