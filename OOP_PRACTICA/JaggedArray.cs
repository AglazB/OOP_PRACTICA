using System;
namespace Task_3_1
{
	public class JaggedArray
	{
        int[][] Array;
        public JaggedArray(int length1, bool manualEntry = false)
        {
            if (manualEntry)
            {
                ManualEntry(length1);
            }
            else
            {
                AutoEntry(length1);
            }
        }
        private void ManualEntry(int length1)
        {
            int n = length1;
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int length2 = int.Parse(Console.ReadLine());
                OneDimentionalArray oneDimentionalArray = new OneDimentionalArray(length1, true);
                array[i] = oneDimentionalArray.oneDimentionArray;
            }
            Array = array;
        }
        private void AutoEntry(int length1)
        {
            Random rnd = new Random();
            int n = length1;
            int[][] array = new int[n][];
            for (int i = 0; i < n; i++)
            {

                OneDimentionalArray oneDimentionalArray = new OneDimentionalArray(rnd.Next(2, 20));
                array[i] = oneDimentionalArray.oneDimentionArray;
            }
            Array = array;
        }
        public void AverageValue()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                OneDimentionalArray oneDimentionalArray = new OneDimentionalArray(Array[i]);
                Console.WriteLine(oneDimentionalArray.AverageValue());
            }

        }
        public void AverageValueWholeArray()
        {
            double summa = 0;
            int length = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    summa += Array[i][j];
                    length++;
                }

            }
            Console.WriteLine(summa / length);
        }

        public void ChangeValues()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    if (Array[i][j] % 2 == 0)
                    {
                        Array[i][j] = i * j;
                    }
                }

            }
        }
        public void Print()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Console.Write($"{Array[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

