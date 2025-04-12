// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will b
// the time complexity?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
//            int large = 0;
//            int secLarge = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                if (array[i] > large)
//                {
//                    large = array[i];
//                }
//                if (array[i] < large && array[i] > secLarge)
//                {
//                    secLarge = array[i];
//                }
//            }

//            Console.WriteLine(secLarge);
//        }
//    }
//}

// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int reversed = 0;
//            while (n > 0)
//            {
//                int reminder = n % 10;
//                reversed = reminder + reversed * 10;
//                n /= 10;
//            }
//            Console.WriteLine(reversed);
//        }
//    }
//}

// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;
//            b = a - b;
//            a = a - b;
//            Console.WriteLine($"A : {a} and B : {b}");
//        }
//    }
//}

// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "silent";
//            string str2 = "listem";
//            if (isAnagram(str1, str2))
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }

//        public static bool isAnagram(string str1, string str2)
//        {
//            if (str1.Length != str2.Length)
//            {
//                return false;
//            }
//            int[] array = new int[256];
//            for (int i = 0; i < str1.Length; i++)
//            {
//                array[str1[i]]++;
//                array[str2[i]]--;
//            }

//            foreach (var i in array)
//            {
//                if (i != 0)
//                {
//                    return false;
//                }
//            }
//            return true;

//        }
//    }
//}

// 4. Find the reverse of the string.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";

//            string reversed = new string(str.Reverse().ToArray());

//            Console.WriteLine(reversed);


//        }
//    }
//}

// 5. WAP to find missing elements from the array?
//using System;
//using System.Linq;
//using System.Collections.Generic;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = { 1, 3, 4, 5, 7, 8, 9, 10 };
//            int min = array.Min();
//            int max = array.Max();
//            var list = new List<int>(array);
//            for (int i = min; i <= max; i++)
//            {
//                if (!list.Contains(i))
//                {
//                    Console.Write(i + " ");
//                }
//            }
//        }
//    }
//}

// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "aabaa";


//            if (isPalindrome(str1))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }
//        }

//        public static bool isPalindrome(string str1)
//        {
//            int left = 0;
//            int right = str1.Length - 1;
//            while (left < right)
//            {
//                if (str1[left] != str1[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}

// 7. WAP to print Fibonacci series with recursion.

using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibo(i) + " ");
            }
        }

        public static int fibo(int n)
        {
            if (n <= 1) return n;
            return fibo(n - 1) + fibo(n - 2);
        }
    }
}