using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array_reverse
{
    class LINQ
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10};
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];

            numbers.Sum();
            //최댓값
            numbers.Max();
            //최솟값
            numbers.Min();
            //평균
            numbers.Average();
            //배열의 원소개수
            Console.WriteLine(numbers.Count());
            //linq의 매개변수는 람다식이 들어온다.
            //numbers에서 n%2==0인 값들을 list로 변환시킨다.
            List<int> list =  numbers.Where(n => n % 2 == 0).ToList();

            //들어온 내용 그대로 선택하여 반환 
            numbers.Select(x => { return x; });
            numbers.Select(x => x);

            //짝수의 최댓값
            //연달아서 호출
            numbers.Where(n => n%2 ==0).Max();

            List<string> techs = new List<string>();
            techs.Add("C#");
            techs.Add("ASP.NET");
            techs.Add("Blazor");

            //오름차순 정렬
            techs.OrderBy(t => t);
            //내림차순
            techs.OrderByDescending(t => t);

            var number = Enumerable.Range(1, 100);
            number.Where(n => n % 2 == 0).Sum();

            //내림차순 정렬 후 짝수 3 개를 가져와라
            numbers.OrderByDescending(n => n).Where(x => x % 2 == 0).Take(3);


            //numbers에서 짝수 선택
            //쿼리 구문
            var q = from n in numbers
                    where n % 2 == 0
                    select n;

            var qq = numbers.Where(n => n % 2 == 0);
        }
    }
}
