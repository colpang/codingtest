/*
문자열 my_string이 매개변수로 주어집니다.
my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
*/
using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        foreach (char a in my_string){
            int n = (int)a;
            if(n>=48 && n<58)
                answer += n-48;
        }
        return answer;
    }
    
    /*
    다른 풀이
    linq를 사용함!
     int answer = my_string.Where(x => char.IsNumber(x)).Sum(x => Convert.ToInt32(x.ToString()));
    */
}