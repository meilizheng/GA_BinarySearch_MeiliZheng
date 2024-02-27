namespace GA_BinarySearch_MeiliZheng
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int array
            int[] array = { 12, 15, 6, 9, 7, 34, 5 };
            //Created a new instance with parameters
            BinarySearch binarySearch = new BinarySearch(array, 0, array.Length - 1, 9);
            //call the RecursiveBinarySearch method to search the target value
            int result = binarySearch.RecursiveBinarySearch(array, 0, array.Length - 1, 9);
            //if the result not equals -1 print out the target value
            if (result != -1)
            {
                Console.WriteLine("Element found at index: " + result);
            }
            //else print out the message to notify user the element not found.
            else
            {
                Console.WriteLine("Element not found in the array.");
            }
        }
    }
}

//Please find the answer in README.
//Include five questions related to binary search algorithm, such as:
//What is binary search and how does it work?
//What is the time complexity of binary search?
//When is binary search preferred over linear search?
//What are the key requirements for binary search to work correctly?
//Can binary search be applied to unsorted arrays? Why or why not?