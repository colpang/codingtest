/*
영어에선 a, e, i, o, u 다섯 가지 알파벳을 모음으로 분류합니다. 
문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
*/

using System;
using System.Linq;
public class Solution {
    public string solution(string my_string) {
        char[] mono = new char[] {'a','e','i','o','u'};
        string answer = "";
        foreach(char alpha in my_string){
            if(!mono.Contains(alpha))
                answer+= alpha;
        }
        return answer;
    }
    
    /*
    replace 함수를 이용하기도 함
      foreach(string c in b)
        {
            my_string = my_string.Replace(c,"");
        }
    */
}