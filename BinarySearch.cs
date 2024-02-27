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
        public BinarySearch()
        {

        }
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
        public int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Not found
        }

        public int RecursiveBinarySearch(int[] array, int left, int right, int target)
        {
            //if the left index value greater that the right index value return -1; because the array  un-ordered.
            if (left > right)
            {
                return -1; // Not found
            }
               

            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
                

            else if (array[mid] < target)
            {
                return RecursiveBinarySearch(array, mid + 1, right, target);
            }
                
            
            else if (array[mid] > target)
            {
                return RecursiveBinarySearch(array, 0, mid - 1, target);
            }
            return -1;

        }
    }
}
