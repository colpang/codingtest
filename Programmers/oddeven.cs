
/*정수가 담긴 리스트 num_list가 주어질 때, num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.*/


using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        var ans1 = (from num in num_list where num%2==0 select num ).Count();
        var ans2 = (from num in num_list where num%2!=0 select num ).Count();
        int[] answer = new int[2] {ans1,ans2};
        
        //이런 풀이도 가능
        /*
        int[] answer = new int[2] { num_list.Count(x => x % 2 == 0), num_list.Count(x => x % 2 == 1) };
        */
        return answer;
    }
}