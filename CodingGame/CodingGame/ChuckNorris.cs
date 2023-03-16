using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class ChuckNorris
    {
        static void Main(string[] args)
        {
            string message = "C";
            string binary_message = "";
            //각 열의 문자를 ascii 코드로 변환하고 10진법에서 2진법으로 변환시키는 for loop
            for (int i = 0; i < message.Length; i++)
            {
                int n = (int)message[i];                        //ascii 코드 변환
                binary_message += ToBinary(n);                  //2진법 변환
                // 시프트 연산자를 사용하면 이진법 변환을 한줄로 구현이 가능하다
                //  int result = num >> i & 1;
            }

            //인코딩
            string answer = "";
            string previous_bit = " ";
            foreach (char bit in binary_message)
            {   //이전 비트와 다른 비트일 경우
                if (!char.Parse(previous_bit).Equals(bit))
                    answer += (bit == '1') ? " 0 " : " 00 ";
                    /*//0인지 1인지 판별후 출력
                    if (bit == '1')
                        answer += " 0 ";
                    else
                        answer += " 00 ";*/
                answer += "0";
                previous_bit = bit.ToString();      //이전 bit를 초기화
            }
            answer = answer.Substring(1);           //문자열 슬라이싱을 통한 맨 처음 공백 삭제
            Console.WriteLine(answer);
        }
        static string ToBinary(int n)
        {
            string result= "";
            
            do
            {
                int remainder = n % 2;
                result += remainder.ToString();
                n = n / 2;
            } while (n>0);
            if (result.Length == 6)
                result += "0";
            //result = new string(result.Reverse().ToArray());
            return new string(result.Reverse().ToArray());
        }
    }
}
