/*
외과의사 머쓱이는 응급실에 온 환자의 응급도를 기준으로 진료 순서를 정하려고 합니다. 정수 배열 emergency가 매개변수로 주어질 때 응급도가 높은 순서대로 진료 순서를 정한 배열을 return하도록 solution 함수를 완성해주세요.
*/
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
    int[] sort = emergency.OrderByDescending(n=>n).ToArray();
    int[] answer = new int[emergency.Length];
        
    for(int i=0;i<sort.Length;i++){
        for (int j=0;j<emergency.Length;j++){
            if(sort[i]== emergency[j]){
                answer[j]=i+1;
            }
        }
    }
        
        /*
        //내림차순 정렬
        int[] order = emergency.OrderByDescending(x => x).ToArray();
        //Linq이용해서 index를 뽑음. Array화
        int[] answer = emergency.Select(x => Array.IndexOf(order, x) + 1).ToArray();
        return answer;
        */
    return answer;
    }
}