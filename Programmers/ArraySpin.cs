/*
정수가 담긴 배열 numbers와 문자열 direction가 매개변수로 주어집니다. 배열 numbers의 원소를 direction방향으로 한 칸씩 회전시킨 배열을 return하도록 solution 함수를 완성해주세요.
*/
using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        for(int i=0;i<numbers.Length;i++)
            answer[(direction == "right" ? (i+1) : (i==0 ? numbers.Length-1:i-1 ) ) %numbers.Length] = numbers[i];
        // 보통은 switch -case 문을 사용함
        return answer;
    }
}