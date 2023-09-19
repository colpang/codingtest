/*
문자열 my_string과 정수 n이 매개변수로 주어질 때, my_string에 들어있는 각 문자를 n만큼 반복한 문자열을 return 하도록 solution 함수를 완성해보세요.
*/
using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        for(int i=0;i<my_string.Length;i++){
            for(int j =0;j<n;j++)
                answer+=my_string[i];
        }
        return answer;
    }
    
    
    /*
    다른 풀이
    1. foreach와 string 함수
     foreach (var c in my_string)
        {
            answer += new string(c, n);
        }

    2. 람다식
        StringBuilder answer = new StringBuilder();
        my_string.ToList().ForEach(s => answer.Append(s, n));
        return answer.ToString();
    
    */
}