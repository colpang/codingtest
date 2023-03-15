using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array_reverse
{
    class gcd
    {
        public int[] solution(int denum1, int num1, int denum2, int num2)
        {
            //분모를 구함 
            var num3 = num1 * num2;
            //분자를 구함
            var denum3 = denum1 * num2 + denum2 * num1;
            //최대공약수를 구함
            var gcd = getgcd(num3, denum3);
            //최대 공약수로 나눈 값을 답으로 함
            num3 /= gcd;
            denum3 /= gcd;

            int[] answer = new int[] { denum3, num3 };
            return answer;
        }

        public int getgcd(int n, int m)
        {
            //두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
            //gcd(m, n%m) 의 재귀함수 반복
            if (m == 0) return n;
            else return getgcd(m, n % m);
            // 이것도 가능 한줄로 줄인것.
            // return (a % b == 0 ? b : gcd(b, a%b))
        }
    }
}
