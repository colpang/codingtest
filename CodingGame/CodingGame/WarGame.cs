using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class WarGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // the number of cards for player 1
            Queue<string> deck1 = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                deck1.Enqueue(Console.ReadLine());  //플레이어 1의 카드 큐에 카드 삽입
            }
            int m = int.Parse(Console.ReadLine()); // the number of cards for player 2
            Queue<string> deck2 = new Queue<string>();
            for (int i = 0; i < m; i++)
            {
                deck2.Enqueue(Console.ReadLine());  //플레이어 2의 카드 큐에 카드 삽입
            }

            int turn = 0;
            int result = 0;
            while(deck1.Count>0 && deck2.Count> 0)
            {
                turn++;
                string card1 = deck1.Dequeue();
                string card2 = deck2.Dequeue();
                result = battle(card1, card2);

                if (result != 0)
                    deckRenew(card1, card2, (result == 1 ? deck1:deck2));
                else
                {
                    result = war(card1, card2, deck1, deck2);
                    if(result ==0)
                        break;
                }
            }

            if (result == 0)
                Console.WriteLine("PAT");
            else
                Console.WriteLine(((deck1.Count>0) ? 1 : 2 ) + " "+turn);
        }

        static int battle(string card1, string card2)
        {
            int card_rank1 = get_rank(card1);
            int card_rank2 = get_rank(card2);
            return (card_rank1 > card_rank2) ? 1 : ((card_rank1 != card_rank2) ? 2 : 0);
        }
        static int get_rank(string card)
        {
            string rank = card.Substring(0, card.Length - 1);
            if (rank.Equals("J"))
                return 11;
            else if (rank.Equals("Q"))
                return 12;
            else if (rank.Equals("K"))
                return 13;
            else if (rank.Equals("A"))
                return 14;
            else
                return int.Parse(rank);
        }
        static void deckRenew(string card1, string card2, Queue<string> deck_win)
        {
            deck_win.Enqueue(card1);
            deck_win.Enqueue(card2);
        }
        //static 정적변수/함수 선언, 클래스로부터 객체를 생성하지 않아도 바로 사용할 수 있음
        //처음으로 사용될 때 초기화,메모리에 할당된 후 계속 사용 
        static int war(string card1, string card2, Queue<string> deck1, Queue<string> deck2)
        {
            int result = 0;
            Queue<string> used_deck1 = new Queue<string>();
            Queue<string> used_deck2 = new Queue<string>();

            used_deck1.Enqueue(card1);
            used_deck2.Enqueue(card2);

            while (deck1.Count>3 && deck2.Count > 3)
            {
                //각각 3번 뽑기
                used_deck1.Enqueue(deck1.Dequeue());
                used_deck1.Enqueue(deck1.Dequeue());
                used_deck1.Enqueue(deck1.Dequeue());

                used_deck2.Enqueue(deck2.Dequeue());
                used_deck2.Enqueue(deck2.Dequeue());
                used_deck2.Enqueue(deck2.Dequeue());

                //결투할 카드 뽑고 사용한 카드에 넣어두기
                card1 = deck1.Dequeue();
                card2 = deck2.Dequeue();
                used_deck1.Enqueue(card1);
                used_deck2.Enqueue(card2);
                //결투 후 처리
                result = battle(card1, card2);
                if (result == 1)
                {
                    for (int i = 0; i < used_deck1.Count; i++)
                        deck1.Enqueue(used_deck1.Dequeue());
                    for (int i = 0; i < used_deck2.Count; i++)
                        deck1.Enqueue(used_deck2.Dequeue());
                    break;
                }
                else if (result == 2)
                {
                    for (int i = 0; i < used_deck1.Count; i++)
                        deck2.Enqueue(used_deck1.Dequeue());
                    for (int i = 0; i < used_deck2.Count; i++)
                        deck2.Enqueue(used_deck2.Dequeue());
                    break;
                }
                    
            }
            return result;
        }
    }
}
