# GA_BinarySearch_MeiliZheng
Include five questions related to binary search algorithm, such as:

**What is binary search and how does it work?**
Binary search is an efficient algorithm for finding an item from a sorted list of items. It works by repeatedly dividing in half the portion of the list that could contain the item, until you've narrowed down the possible locations to just one. We used binary search in the guessing game in the introductory tutorial.

**How does it work?**
Binary Search Algorithm can be implemented in two ways which are discussed below.

Iterative Method
Recursive Method

The recursive method follows the divide and conquer approach.
The general steps for both methods are discussed below.

The array in which searching is to be performed is:

- initial array Binary Search
- Initial array
- Let x = 4 be the element to be searched.
- Set two pointers low and high at the lowest and the highest positions respectively.
- setting pointers Binary Search
- Setting pointers
- Find the middle element mid of the array ie. arr[(low + high)/2] = 6.
- mid element Binary Search
- Mid element
- If x == mid, then return mid.Else, compare the element to be searched with m.
- If x > mid, compare x with the middle element of the elements on the right side of mid. This is done by setting low to low = mid + 1.
- Else, compare x with the middle element of the elements on the left side of mid. This is done by setting high to high = mid - 1.
- finding mid element Binary Search
- Finding mid element
- Repeat steps 3 to 6 until low meets high.
- mid element Binary Search
- Mid element
- x = 4 is found.
- found Binary Search
- Found

**What is the time complexity of binary search?**
The time complexity of the binary search algorithm is O(log n). The best-case time complexity would be O(1) when the central index would directly match the desired value.
  
**When is binary search preferred over linear search?**
  Binary Search is more optimized and efficient than Linear Search in many ways, especially when the elements are in sorted order.
  
**What are the key requirements for binary search to work correctly?**
The binary search required the dataset to be sorted in ascending or descending order. Sorting allows systematic comparison with the middle element, enabling the algorithm to determine whether or not the target value lies to the left or right.
  
**Can binary search be applied to unsorted arrays? Why or why not?**
it is not possible to use or implement Binary Search on unsorted arrays or lists, because, the repeated targeting of the mid element of one half depends on the sorted order of data structure.
