/*
머쓱이는 친구들과 동그랗게 서서 공 던지기 게임을 하고 있습니다. 공은 1번부터 던지며 오른쪽으로 한 명을 건너뛰고 그다음 사람에게만 던질 수 있습니다. 친구들의 번호가 들어있는 정수 배열 numbers와 정수 K가 주어질 때, k번째로 공을 던지는 사람의 번호는 무엇인지 return 하도록 solution 함수를 완성해보세요.
*/
using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer =1+(2*(k-1)) % numbers.Max();
        return answer;
    }
}

/*
Queue로 풀이한 방법 (인상깊어서 가져와봄)

using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] numbers, int k) 
    {
        int answer = 0;

        var q = new Queue<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            q.Enqueue(numbers[i]);
        }

        for (int j = 0; j < k; j++)
        {
            for (int i = 0; i < 2; i++)
            {
                var top = q.Peek();

                if (i == 0)
                {
                    answer = top;
                }
                q.Dequeue();
                q.Enqueue(top);   
            }
        }

        return answer;
    }
}


*/