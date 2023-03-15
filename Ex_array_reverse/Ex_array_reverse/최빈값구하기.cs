using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array_reverse
{
    class 최빈값구하기
    {
        public static int solution(int[] array)
        {
            int answer = 0;
            int val = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            //횟수를 세서 딕셔너리에 추가
            foreach (int n in array)
            {
                if (map.ContainsKey(n))
                    map[n] = map[n] + 1;
                else
                    map.Add(n, 1);
            }

            //최빈값 선출
            foreach (KeyValuePair<int, int> num in map)
            {
                if (num.Value > val)
                {
                    answer = num.Key;
                    val = num.Value;
                }
                //최빈값이 중복되면 answer를 -1로 변경함.
                else if (num.Value == val)
                    answer = -1;

            }
            return answer;
        }

        //다른 풀이
         int solution2(int[] array)
        {
            int answer = 0;
            int iMax = 0;
            int iCount = 0;
            //distinct, 중복제거 메소드, 112233 이 있으면 123반환
            foreach (int val in array.Distinct())
            {
                // array에서 val과 같은 것을 세는 LINQ
                iCount = array.Count(x => x == val);
                //최빈값최대보다 크면 값 변경
                if (iCount > iMax)
                {
                    iMax = iCount;
                    answer = val;
                }
                //만약 최빈값이 2개 이상이면 결과를 -1로 바꿈
                else if (iCount == iMax)
                {
                    answer = -1;
                }
            }

            return answer;
        }

    }
}
