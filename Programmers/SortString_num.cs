/*
문자열 my_string이 매개변수로 주어질 때, my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 return 하도록 solution 함수를 작성해보세요.
*/

using System;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[my_string.Where(x => char.IsNumber(x)).Count()];
        int index=0;
        
        foreach(char a in my_string){
            if(char.IsNumber(a)){
                answer[index]=(int)a-48;
                index++;
            }
        }
        return answer.OrderBy(n=>n).ToArray();
    }
}
/*
Select와 int.Parse를 통한 문자열 선별
Sort()를 통한 오름차순 정렬
my_string = System.Text.RegularExpressions.Regex.Replace(my_string, "[^0-9]", "");
int[] answer = my_string.Select(x => int.Parse(x.ToString())).ToArray();
Array.Sort(answer);
return answer;

*/