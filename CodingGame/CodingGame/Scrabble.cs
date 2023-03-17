using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class Scrabble
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> word_dictionary = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string W = Console.ReadLine();
                word_dictionary.Add(W);
            }
            string LETTERS = Console.ReadLine();

            int max_score = 0;
            string max_score_word = " ";

            foreach (string word in word_dictionary)
            {   
                int score = 0;
                if (is_word_feasible(word, LETTERS))
                    score = get_word_score(word);
                if (max_score < score)
                {
                    max_score = score;
                    max_score_word = word;
                }
            }
            Console.WriteLine(max_score_word);
        }
        static bool is_word_feasible(string word, string letters)
        {
            foreach (char c in word)
            {
                if (word.Count(x=>x == c) > letters.Count(x => x == c))
                    return false;
            }
            return true;
        }
        static int get_word_score(string word)
        {
            Dictionary<char, int> char_dic = new Dictionary<char, int>() {
                {'a',1}, { 'b', 3 }, { 'c', 3 }, { 'd', 2 },
                {'e',1}, { 'f', 4 }, { 'g', 2 }, { 'h', 4 },
                {'i',1}, { 'j', 8 }, { 'k', 5 }, { 'l', 1 },
                {'m',3}, { 'n', 1 }, { 'o', 1 }, { 'p', 3 },
                {'q',10}, { 'r', 1 }, { 's', 1 }, { 't', 1 },
                {'u',1}, { 'v', 4 }, { 'w', 4 }, { 'x', 8 },{'y',4},{'z',10}
            };

            int score = 0;
            foreach(char c in word)
                score += char_dic[c];
            return score;
        }
    }
}
