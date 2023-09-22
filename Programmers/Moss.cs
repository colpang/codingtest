/*
머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다. 그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다. 
문자열 letter가 매개변수로 주어질 때, letter를 영어 소문자로 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
모스부호는 다음과 같습니다.
*/
using System;
using System.Linq;

public class Solution {
    public string solution(string letter) {
        //string[] splitLetter = letter.Split(' ');
        string[] moss = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        /*
        string answer ="";
        foreach (string split in splitLetter){
            for(int i=0;i<moss.Length;i++){
                if(split == moss[i])
                    answer+= (char)(i+97);
            }
        }
        */
        foreach (string t in letter.Split(' ')){
            answer += Convert.ToChar(Array.IndexOf(moss, t)+97);
            //Convert.ToChar 메서드 : 지정된 개체의 값을 유니코드 문자로 변환합니다.
            //Array.IndexOf()   :    Array.IndexOf() 메서드는 배열에서 특정 값을 만족하는 첫 번째 위치를 반환합니다. Array.IndexOf(검색할 1차원 배열, array에서 찾을 값)
        }
        return answer;
        
    }
}