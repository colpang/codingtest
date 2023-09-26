/*
i팩토리얼 (i!)은 1부터 i까지 정수의 곱을 의미합니다. 
예를들어 5! = 5 * 4 * 3 * 2 * 1 = 120 입니다. 
정수 n이 주어질 때 다음 조건을 만족하는 가장 큰 정수 i를 return 하도록 
solution 함수를 완성해주세요.
*/

using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer=0;
        int sum=1;
        
        for (int i=1;i<11;i++){
            sum = sum * i;
            if(sum >= n)
            {
                if(sum == n)
                    answer= i;
                else
                    answer= i-1;
                break; 
            }

        }
        return answer;
    }
    
    
    public int fact(int n){
        if(n<=1)
            return 1;
        else 
            return n*fact(n-1);
    }
}
    