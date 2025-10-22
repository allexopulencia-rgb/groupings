using System;


namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 21 };
            int target = 4;

            int index = BinarySearch(arr, target);

            if (index != -1)
            {
                Console.WriteLine($"The value {target} was found at index {index}");
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            Console.ReadLine();
        }

        public static int BinarySearch(int[] arr, int target)
        {
           int left = 0;
           int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
