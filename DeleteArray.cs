using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class DeleteArray
    {
        public void delIntArray(int[] numbers, int position)
        {
            Console.WriteLine("Before deleting the element the int array is");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            // This for loop for deleting the element
            for (int i = position; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            Console.WriteLine("After deleting the element");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

        }
        public void delDoubleArray(double[] doubles, int position)
        {
            Console.WriteLine("Before deleting the element the double array is");
            foreach (double du in doubles)
            {
                Console.Write(du + " ");
            }
            Console.WriteLine();
            // This for loop for deleting the element
            for (int i = position; i < doubles.Length - 1; i++)
            {
                doubles[i] = doubles[i + 1];
            }
            Console.WriteLine("After deleting the element");
            foreach (double du in doubles)
            {
                Console.Write(du + " ");
            }
        }
        public void delCharArray(char[] chars, int position)
        {
            Console.WriteLine("Before deleting the element the char array is");
            foreach (char ch in chars)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            // This for loop for deleting the element
            for (int i = position; i < chars.Length - 1; i++)
            {
                chars[i] = chars[i + 1];
            }
            Console.WriteLine("After deleting the element");
            foreach (char ch in chars)
            {
                Console.Write(ch + " ");
            }

        }
    }
}
