using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siftup
{
    class program2
    {
        static void Main(string[] args)
        {
            string[] card = new string[] {"AABBCCDD","KKKKJJJJ","MOMOMOMO"};
            string[] word = new string[] { "AAAKKKKKMMMMM","ABCDKJ"};
            string[] answer = solution(card, word);
            foreach (string word_p in answer)
                Console.WriteLine(word_p);
        }
        static string[] solution(string[] card, string[] word)
        {
            string[] answer = new string[] {};
            List<string> result = new List<string>();
            string letters = card[0] + card[1] + card[2];

            foreach (string s in word)
            {
                bool first_line = false;
                bool second_line = false;
                bool third_line = false;
                bool is_possible = true;
                foreach (char c in s)
                {
                    if (s.Count(x => x == c) <= letters.Count(x => x == c))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (card[i].Contains(c))
                            {
                                if (i == 0)
                                    first_line = true;
                                else if (i == 1)
                                    second_line = true;
                                else
                                    third_line = true;
                                break;
                            }

                        }

                    }
                    else
                    {
                        is_possible = false;
                        break;
                    }
                }
                if(first_line && second_line && third_line && is_possible)
                    result.Add(s);
            }

            if (result.Count == 0)
                result.Add("-1");
            answer = result.ToArray();
            return answer;
        }
    }
}
