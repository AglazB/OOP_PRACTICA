using System;
namespace Task_3_1
{
    public class OneDimentionalArray
    {
        private int[] Array;
        public OneDimentionalArray(int length, bool manualEntry = false)
        {
            if (manualEntry)
            {
                ManualEntry(length);
            }
            else
            {
                AutoEntry(length);
            }
        }
        public OneDimentionalArray(int[] array)
        {
            Array = array;
        }
        public int[] oneDimentionArray
        {
            get
            {
                return Array;
            }
        }
        private void ManualEntry(int length)
        {
            int n = length;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array = array;
        }
        private void AutoEntry(int length)
        {
            Random rnd = new Random();
            int n = length;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-200, 200);
            }
            Array = array;
        }

        public double AverageValue()
        {
            double summa = 0;
            foreach (int el in Array)
            {
                summa += el;
            }
            return summa / Array.Length;

        }
        public void DeleteElementsGreate100()
        {
            int n = Array.Length;
            foreach (int el in Array)
            {
                if (Math.Abs(el) > 100)
                {
                    n = n - 1;
                }
            }
            int[] ArrayElementsLess100 = new int[n];
            int i = 0;
            foreach (int el in Array)
            {
                if (Math.Abs(el) <= 100)
                {
                    ArrayElementsLess100[i] = el;
                    i = i + 1;
                }
            }
            Array = ArrayElementsLess100;
        }
        public void DeleteDublicates()
        {
            int[] ArrayWithoutDublicates = Array.Distinct().ToArray();
            Array = ArrayWithoutDublicates;
        }

        public void Print()
        {
            foreach (int el in Array)
            {
                Console.Write($"{el}, ");
            }
        }
    }
}

