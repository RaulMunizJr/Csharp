using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class Program
    {
        static bool Linear_search(int[] A, int x)
        {
            int n = A.Length;
            for (int i = 0; i < n; ++i)
                if (A[i] == x)
                    return true;
            return false;

            /*  Time        /       Space
             *  O(n)                O(1)
             */
        }

        /*************************************************************/

        static bool BinarySearch(int[] A, int l, int r, int x) //must be sorted!
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (A[mid] == x)
                    return true;
 
                if (A[mid] > x)
                    return BinarySearch(A, l, mid - 1, x);

                return BinarySearch(A, mid + 1, r, x);
            }

            return false;

            /*  Time        /       Space
             *  O(log(n))           O(log(n))
             */
        }

        /*************************************************************/

        static void InsertionSort(int[] arr) //hand of cards
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            /*  Time        /       Space
             *  O(n^2)                  O(1)
             */

            for(int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        /*************************************************************/

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            { 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];//swap
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            /*  Time        /       Space
             *  O(n^2)              O(1)
             */

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }


        //static void printArray(int[] arr)
        //{
        //    int n = arr.Length;
        //    for (int i = 0; i < n; ++i)
        //        Console.Write(arr[i] + " ");

        //    Console.Write("\n");
        //}
        /******************************************************************************************************/

        static void Main(string[] args)
        {
            int[] theArray = { 1, -5, 8, 3, 5, 54, 38, 99, 7, 9 };
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            SelectionSort(theArray);
        }
    }

}


