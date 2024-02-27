using System.Diagnostics;

namespace GA_BinarySearch_MeiliZheng
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int array
            int[] array = { 2, 4, 6, 9, 12, 23, 45, 60};
            int target = 60;
            //Created a new instance with parameters
            BinarySearch binarySearch = new BinarySearch();
            //Created a new instance for stopwatch
            Stopwatch stopwatch = new Stopwatch();   
            //start stopwatch
            stopwatch.Start();
            //assign int interativeResult
            int iterativeResult = binarySearch.IterativeBinarySearch(array, target);
            //stop stopwatch
            stopwatch.Stop();
            //print out the result
            Console.WriteLine("Iterative Binary Search:");
            if(iterativeResult != -1) 
            {
                Console.WriteLine($"Element found at index: {iterativeResult}");
            }
            else
            {
                Console.WriteLine("Element not fount.");
            }
            //print out the total time used.
            Console.WriteLine("Time taken: " + stopwatch.Elapsed);

            // Measure time taken for Recursive Binary Search
            stopwatch.Reset();
            stopwatch.Start();
            //use ResursiveBinarySeach find the target number.
            int recursiveResult = binarySearch.RecursiveBinarySearch(array, 0, array.Length - 1, target);
            stopwatch.Stop();
            Console.WriteLine("\nRecursive Binary Search:");
            if(recursiveResult != -1)
            {
                Console.WriteLine($"Element found at index: {recursiveResult}");
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
            //print out the total time used.
            Console.WriteLine("Time taken: " + stopwatch.Elapsed);
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