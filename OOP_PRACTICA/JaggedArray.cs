using System;
namespace Task_3_1
{
	public class JaggedArray
	{
        OneDimentionalArray[] Array;
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
            OneDimentionalArray[] array = new OneDimentionalArray[n];
            for (int i = 0; i < n; i++)
            {
                int length2 = int.Parse(Console.ReadLine());
                array[i] = new OneDimentionalArray(length2, true); ;
            }
            Array = array;
        }
        private void AutoEntry(int length1)
        {
            Random rnd = new Random();
            int n = length1;
            OneDimentionalArray[] array = new OneDimentionalArray[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = new OneDimentionalArray(rnd.Next(2, 20));
            }
            Array = array;
        }
        public void AverageValues()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i].AverageValue());
            }

        }
        public void AverageValueWholeArray()
        {
            double summa = 0;
            int length = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].GetLength(); j++)
                {
                    summa += Array[i].GetElement(j);
                    length++;
                }

            }
            Console.WriteLine(summa / length);
        }

        public void ChangeValues()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array[i].GetLength(); j++)
                {
                    if (Array[i].GetElement(j) % 2 == 0)
                    {
                        Array[i].SetValue(j, i, j);
                    }
                }

            }
        }
        public void Print()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i].Print();
                Console.WriteLine();
            }
        }
    }
}

