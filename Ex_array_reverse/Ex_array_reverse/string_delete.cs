using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_array_reverse
{
    class string_delete
    {
        static void Main(string[] args)
        {
            solution("abcdef", "f");
        }
        public static string solution(string my_string, string letter)
        {
            string answer = "";
            for (int i = 0; i < my_string.Length; i++)
            {
                if (!my_string[i].Equals(char.Parse(letter)))
                    answer += my_string[i];
            }
            return answer;
        }

    }
}
