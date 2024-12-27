namespace Assignment_6_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 6.1.3
             * 
             * Given an integer array nums, move all 0's to the end of it 
             * while maintaining the relative order of the non-zero elements.
             * 
             * Note that you must do this in-place without making a copy of the array.
             */

            int[] ints = { 1, 2, 0, 0, 3, 4, 0, 5 };
            int n = ints.Length;

            Console.Write("Original Array: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{ints[i]} ");

            AdjustInts(ints);

            Console.Write("Adjusted Array: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{ints[i]} ");
        }

        static void AdjustInts(int[] ints)
        {
            int left = 0;
            int right = left + 1;
            int n = ints.Length;

            while (right < n)
            {
                if (ints[left] != 0)
                {
                    left++;
                    continue;
                }

                if (right < left || ints[right] == 0)
                {
                    right++;
                    continue;
                }

                int temp = ints[left];
                ints[left] = ints[right];
                ints[right] = temp;
            }
        }
    }
}
