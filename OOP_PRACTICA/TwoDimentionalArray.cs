using System;
namespace Task_3_1
{
    public class TwoDimentionalArray
    {

        int[,] Array;

        public TwoDimentionalArray(int length1, int length2, bool manualEntry = false)
        {
            if (manualEntry)
            {
                ManualEntry(length1, length2);
            }
            else
            {
                AutoEntry(length1, length2);
            }
        }
        private void ManualEntry(int length1, int length2)
        {
            int n = length1;
            int m = length2;
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Array = array;
        }
        private void AutoEntry(int length1, int length2)
        {
            Random rnd = new Random();
            int n = length1;
            int m = length2;
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(-200, 200);
                }
            }
            Array = array;
        }
        public void PrintNormal()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();

            }
        }
        public void Print()
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = Array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write($"{Array[i, j]} ");
                    }
                }
                else
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        Console.Write($"{Array[i, j]} ");
                    }
                }
                Console.WriteLine();


            }
        }

    }
}

