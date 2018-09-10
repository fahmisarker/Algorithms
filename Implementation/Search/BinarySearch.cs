using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Search
{
    public class BinarySearch
    {
        /// <summary>
        /// Binary search compares the target value to the middle element of the array. 
        /// If they are not equal, the half in which the target cannot lie is eliminated and 
        /// the search continues on the remaining half, again taking the middle element 
        /// to compare to the target value, and repeating this until the target value is found.
        /// </summary>
        /// <param name="a">The SORTED array that needs to be searched</param>
        /// <param name="value">The value that we are searching. </param>
        /// <returns>Index of the item if found. -1 if not found.</returns>
        /// <example>BinarySearchIterative(new int[]{3,5,2,5,1},5)</example>
        public static int BinarySearchIterative(int[] a, int value) {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;

                if (a[mid].Equals(value))
                    return mid;
                else if (value < a[mid])
                {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Array to search</param>
        /// <param name="value">Value to look for</param>
        /// <param name="index">Initial index. Default to -1</param>
        /// <param name="left">Left search bound index. Start with 0</param>
        /// <param name="right">Right search bound index. Start with a.Length - 1</param>
        /// <returns>Index of array a if found. -1 if not (assuming you default index to -1)</returns>
        /// <example>BinarySearchRecursive(new int[] { 3,3,4,2, 2, 5, 1 }, 5,-1,0,6))</example>
        public static int BinarySearchRecursive(int[] a, int value, int index, int left, int right) {

            if (left <= right)
            {
                int mid = left + ((right - left) / 2);

                // If value is found
                if (value == a[mid])
                {
                    index = mid;
                }
                else
                {
                    // if value < array[midIndex], search left
                    if (value < a[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    { // if value > array[midIndex], search right
                        left = mid + 1;
                    }

                    index = BinarySearchRecursive(a, value, index, left, right);
                }
            }

            return index;
        }
    }
}
