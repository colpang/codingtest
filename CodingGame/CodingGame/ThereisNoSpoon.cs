using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingGame
{
    class ThereisNoSpoon
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());  // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            
            char[,] arr = new char[height,width];       //0과 .을 담을 2차원 배열
            for (int y = 0; y < height; y++)            //height만큼 반복함. y값(행)
            {
                string line = Console.ReadLine();       // width characters, each either 0 or .
                for(int x=0;x<width;x++)                //배열에 값을 할당. x값(열)
                    arr[y, x] = line[x];
            }
            
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if (arr[y,x] == '0')
                    {
                        (int rightX, int rightY) = findRightPowerNode(x, y, arr, width, height);
                        (int lowerX, int lowerY) = findLowerPowerNode(x, y, arr, width, height);
                        Console.WriteLine(x + " " + y + " " + rightX + " " + rightY + " " + lowerX + " " + lowerY);
                    }
                }
            }
        }

        static (int,int) findRightPowerNode(int powerX, int powerY, char[,] arr, int width, int height)
        {
            for(int x = powerX + 1; x <width; x++)
            {
                if (arr[powerY,x] == '0')
                    return (x, powerY);
            }
            return (-1, -1);
        }

        static (int, int) findLowerPowerNode(int powerX, int powerY, char[,] arr, int width, int height)
        {
            for (int y = powerY + 1; y < height; y++)
            {
                if (arr[y, powerX] == '0')
                    return (powerX, y);
            }
            return (-1, -1);
        }
    }
}
