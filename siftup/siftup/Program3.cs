using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siftup
{
    class Program3
    {
        static void Main(string[] args)
        {
            string block = ">><>>";
            int pos =2;
            long answer = solution(block, pos);
            Console.WriteLine(answer);
        }

        static long solution(string block, int pos)
        {
            long answer = 0;
            char[] rails = block.ToArray();
            while(pos > 0 && pos < block.Length + 1){
                if (rails[pos - 1] == '<'){
                    rails[pos - 1] = '>';
                    pos--;
                }
                else{
                    rails[pos - 1] = '<';
                    pos++;
                }
                answer++;
            }
            return answer;
        }
    }
}
