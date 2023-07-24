namespace GenericsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problem");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] doubles = { 1.1, 2.3, 4.5, 5.6 };
            char[] chars = { 'a', 'e', 'i', 'o', 'u' };
            DeleteArray deleteArray = new DeleteArray();
            deleteArray.delIntArray(numbers, 2);
            Console.WriteLine();
            deleteArray.delDoubleArray(doubles, 1);
            Console.WriteLine();
            deleteArray.delCharArray(chars, 3);
            Console.WriteLine();
        }
    }
}