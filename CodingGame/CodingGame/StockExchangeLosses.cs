using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class StockExchangeLosses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());              //주식 개수
            string[] inputs = Console.ReadLine().Split(' ');    //주식 값 배열

            int highest_price = 0;                                        //최고가
            int max_loss = 0;                                     //최대 손실
            foreach (string price in inputs)
            {
                int v = int.Parse(price);                   //현재 주식값
                if (highest_price < v)
                    highest_price = v;                           //현재 값이 최고가보다 높을 경우 최고가 갱신
                if (v - highest_price < max_loss)
                    max_loss = v - highest_price;         //현재값-최고가가 최대손실보다 작을경우 최대손실 갱신
            }
            Console.WriteLine(max_loss);
        }
    }
}
