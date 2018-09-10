using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Arrays
{
    public class General
    {
        public void Do()
        {
            int[] a = { 0, 1, 2, 3, 4 };
            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };


            for (int x = 0; x < array2D.GetLength(0); x += 1)
            {
                for (int y = 0; y < array2D.GetLength(1); y += 1)
                {
                    Console.Write(array2D[x, y]);
                }
            }
        }

        void DoJagged()
        {
            int[][] arr = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };

            // Display the array elements:
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}