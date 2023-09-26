/*
약수의 개수가 세 개 이상인 수를 합성수라고 합니다. 
자연수 n이 매개변수로 주어질 때 n이하의 합성수의 개수를 return하도록 solution 함수를 완성해주세요.


*/
using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if(n!=1){
            for(int i=1; i<=n;i++){
                for(int j=2;j<n;j++){
                    if(i%j==0 && i!=j){
                        answer++;
                        break;
                    }

                }
            }
        }
        return answer;
        
        
        /*
        for (int i = 4; i <= n; i++)
        {
            answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
        }
        */
    }
}