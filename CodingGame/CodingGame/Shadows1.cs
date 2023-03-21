using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class Shadows1
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);


            int left_x = 0, low_y=0;
            int right_x = W - 1, high_y =H-1;
            // game loop
            while (true)
            {
                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
                if (bombDir.Contains('R')) 
                    left_x = X0 + 1;
                else if (bombDir.Contains('L')) 
                    right_x = X0 - 1;
                else
                {
                    left_x = X0;
                    right_x = X0;
                }
                if (bombDir.Contains('U'))
                    high_y = Y0 - 1;
                else if (bombDir.Contains('D'))
                    low_y = Y0 + 1;
                else
                {
                    low_y = Y0;
                    high_y = Y0;
                }
                X0 = (left_x + right_x) / 2;
                Y0 = (low_y + high_y) / 2;



                Console.WriteLine(X0 + " "+ Y0);
            }
        }

        //이진 탐색
        //탐색할 구간을 절반씩 줄여가며 탐색하는 알고리즘
        //탐색할 데이터가 미리 정렬되어있어야 사용할 수 있다.
        //시간 복잡도는 O(logN)
        static int binary_search(int [] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] > value)
                    high = mid - 1;
                else if (array[mid] < value)
                    low = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
