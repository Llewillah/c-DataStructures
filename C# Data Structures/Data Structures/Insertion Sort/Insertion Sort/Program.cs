using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Insertion_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 200;
            int[] test2 = new int[10];
            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }

            Console.WriteLine("Insertion Sort - BEFORE SORTING");
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }
            Console.WriteLine(IsInOrder(test2));
            Console.WriteLine(test2.Length);
            PeakValley(test2);
   
            Console.WriteLine("Insertion Sort - AFTER SORTING");
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }

            Console.WriteLine(IsInOrder(test2));


            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389",
            "84928334", "4839455", "21331322", "348923948", "43893284",
                "9483294", "9823943" };
            Book[] library = new Book[10];
            // create an array of books
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
            }

            Console.WriteLine("Insertion Sort - BEFORE SORTING");
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i].Title);
            }
            InsertionSortBooks(library);
            Console.WriteLine("Insertion Sort - AFTER SORTING");
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i].Title);
            }


            Console.ReadKey();
        }

        static public void InsertionSort(int[] nums) 
        {
            for (int i = 1; i < nums.Length; i++) 
            {
                int value = nums[i];
                int j = i;

                for (; j > 0 && value < nums[j - 1]; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[j] = value;
            }
        }

        static public void InsertionSortBooks(Book[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                Book value = nums[i];
                int j = i;

                for (; j > 0 && value.Title.CompareTo(nums[j-1].Title) < 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[j] = value;
            }
        }

        static public bool IsInorder(int[] nums) 
        {
            for (int i = 0; i < nums.Length - 1; i++) 
            {
                if (nums[i] > nums[i + 1]) 
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsInOrder<T>(T[] a) where T : IComparable
        {
            for(int i = 0; i < a.Length -1;i++) 
            {
                if (a[i].CompareTo(a[i + 1]) == 1) 
                {
                    return false;
                }
            }
            return true;
        }

        static public void BubbleSort(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = 0; j < nums.Length - 1 - i; j++) 
                {
                    if (nums[j] > nums[j + 1]) 
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        static public void SelectionSort(int[] nums) 
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[smallest])
                    {
                        smallest = j;
                    }
                }
                int temp = nums[i];
                nums[i] = nums[smallest];
                nums[smallest] = temp;
            }

        }

        static public void PeakValley(int[] nums)
        {
            int[] peaks = new int[nums.Length/2];
            int[] valleys = new int[nums.Length/2];

            if (!IsInorder(nums)) 
            { 
                InsertionSort(nums);
            }

            for (int i = 0; i <= nums.Length / 2 - 1; i++) 
            {
                valleys[i] = nums[i];
                peaks[i] = nums[nums.Length-i-1];
            }

            for (int i = 0; i < nums.Length/2; i++) 
            {
                nums[i*2] = peaks[i];
                nums[i * 2 + 1] = valleys[i];
            }
        }
    }
}
