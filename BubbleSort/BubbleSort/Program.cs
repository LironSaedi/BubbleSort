using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void BuubleSort(int[] bubble)
        {
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length; i++)
                {
                    if (bubble[i] > bubble[i + 1])
                    {
                        int temp = bubble[i + 1];
                        bubble[i + 1] = bubble[i];
                        bubble[i] = temp;

                    }
                }
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}
