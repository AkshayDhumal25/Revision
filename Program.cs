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
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 12;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"A : {a} and B : {b}");
        }
    }
}