/*
머쓱이는 구슬을 친구들에게 나누어주려고 합니다. 구슬은 모두 다르게 생겼습니다. 머쓱이가 갖고 있는 구슬의 개수 balls와 친구들에게 나누어 줄 구슬 개수 share이 매개변수로 주어질 때, balls개의 구슬 중 share개의 구슬을 고르는 가능한 모든 경우의 수를 return 하는 solution 함수를 완성해주세요.
*/
using System;

public class Solution {
    /*public long solution(int balls, int share) {
        long answer=factorial(balls)/factorial(balls-share)/factorial(share);
        return answer;
    }
    
    public long factorial(int n){
        if(n==1 || n==0)
            return 1;
        else
            return n*factorial(n-1);
    }*/
    public long solution(int balls, int share) { 
        // Math.Min()은 둘중 더 작은 값을 반환함
        share = Math.Min(balls - share, share);
        
        // 재귀함수를 돌면서 share가 0이면 1을 리턴
        if (share == 0)
            return 1;

        // 재귀함수를 통해 balls와 share를 1씩 줄임
        long answer = solution(balls - 1, share - 1);
        answer *= balls;
        answer /= share;
        
        // 한줄 코드 return share == 0 ? 1 : solution(balls - 1, share -1) * balls / share;
        return answer;
    }
}