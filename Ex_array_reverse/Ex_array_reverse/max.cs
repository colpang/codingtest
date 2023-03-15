using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array_reverse
{
    class max
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            int answer = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (answer <= numbers[i] * numbers[j])
                        answer = numbers[i] * numbers[j];
                }
            }
        }

        //다른 풀이
        void solution()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //내림차순으로 정렬 후 배열로 변환
            //앞에 두 개 곱하기
            numbers = numbers.OrderByDescending(x => x).ToArray();
            int answer = numbers[0] * numbers[1];
        }
    }
}
