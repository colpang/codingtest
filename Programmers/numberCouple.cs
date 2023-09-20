/*
순서쌍이란 두 개의 숫자를 순서를 정하여 짝지어 나타낸 쌍으로 (a, b)로 표기합니다. 자연수 n이 매개변수로 주어질 때 두 숫자의 곱이 n인 자연수 순서쌍의 개수를 return하도록 solution 함수를 완성해주세요.
*/
using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for (int i=0; i<n;i++){
            if ((n%(i+1) )==0)
                answer++;
        }
            /*
              int answer = Enumerable.Range(1, n).Count(x => n % x == 0);
              */
        return answer;
    }
}