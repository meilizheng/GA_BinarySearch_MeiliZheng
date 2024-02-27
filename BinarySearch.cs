using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch_MeiliZheng
{
    public class BinarySearch
    {
        //Field
        int[] array;
        int left;
        int right;
        int target;


        //Constructor
        public BinarySearch(int[] array, int left, int right, int target)
        {
            this.Array = array;
            this.Left = left;
            this.Right = right;
            this.Target = target;
        }

        //Property
        public int[] Array { get => array; set => array = value; }
        public int Left { get => left; set => left = value; }
        public int Right { get => right; set => right = value; }
        public int Target { get => target; set => target = value; }

        //Method
        public int RecursiveBinarySearch(int[] array, int left, int right, int target)
        {
            //if the left index value greater that the right index value return -1; because the array in not in codered.
            if (left > right)
            {
                return -1;
            }

            //assign the mid index value
            int mid = (left + (right - left)) / 2;
            //if mid index value equals to the target, return the mid index value. target found.
            if (array[mid] == target)
            {
                return mid;
            }
            //else if mid index value less than target value do the recursive binary search on the right hale of the array.
            else if (array[mid] < target)
            {
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }
            // else, do the recursive binary search on the left half of the array.
            else
            {
                return RecursiveBinarySearch(array, target, left, mid - 1);
            }
        }
    }
}
