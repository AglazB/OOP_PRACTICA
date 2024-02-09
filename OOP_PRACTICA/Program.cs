using System;
using System.Linq;
using Task_3_1;
using static System.Runtime.InteropServices.JavaScript.JSType;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Демонстрация работы с одномерным массивом:");
        Console.WriteLine("Введите длину массива");
        int length = int.Parse(Console.ReadLine());
        OneDimentionalArray oneDimensionalArray = new OneDimentionalArray(length);
        Console.WriteLine("Ваш массив");
        oneDimensionalArray.Print();
        Console.WriteLine();
        Console.WriteLine("Ваш массив, после удаления элементов больше 100 по модулю");
        oneDimensionalArray.DeleteElementsGreate100();
        oneDimensionalArray.Print();
        Console.WriteLine();
        Console.WriteLine("Ваш массив, после удаления дубликатов");
        oneDimensionalArray.DeleteDublicates();
        oneDimensionalArray.Print();
        Console.WriteLine();
        Console.WriteLine("Демонстрация работы с двумерным массивом");
        Console.WriteLine("Введите количество строк массива");
        int firstlength = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов массива:");
        int secondlength = int.Parse(Console.ReadLine());
        TwoDimentionalArray twoDimensionalArray = new TwoDimentionalArray(firstlength, secondlength);
        Console.WriteLine("Ваш массив");
        twoDimensionalArray.PrintNormal();
        Console.WriteLine();
        Console.WriteLine("Ваш массив, выведенный по условию второго пункта");
        twoDimensionalArray.Print();
        Console.WriteLine();
        Console.WriteLine("Демонстрация работы со ступенчатым массивом:");
        Console.WriteLine("Введите длину массива");
        int length2 = int.Parse(Console.ReadLine());
        JaggedArray jaggedlArray = new JaggedArray(length2);
        Console.WriteLine("Ваш массив");
        jaggedlArray.Print();
        Console.WriteLine();
        Console.WriteLine("Среднее значение в массиве");
        jaggedlArray.AverageValueWholeArray();
        Console.WriteLine("Средние значения в массивах");
        jaggedlArray.AverageValue();
        Console.WriteLine("Массив с изменёнными чётными по значению элементами");
        jaggedlArray.ChangeValues();
        jaggedlArray.Print();
    }
}


