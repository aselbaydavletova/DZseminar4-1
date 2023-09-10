// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int x(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     //int result = Math.Pow(numberA, numberB);
//     return result;
// }

// System.Console.WriteLine("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int x = Exponentiation(numberA, numberB);
// System.Console.WriteLine("Ответ: "+ Exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());


// int SumNumber(int numberN)
// {
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++)
//     {
//         advance = numberN - numberN % 10;
//         result = result + (numberN - advance);
//         numberN = numberN / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(numberN);
// System.Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

System.Console.WriteLine("Введите ряд чисел, разделенных запятой: ");
string seriesOfNumbers = Console.ReadLine();

{
    seriesOfNumbers = seriesOfNumbers + ",";
    string RemovingSpaces(string series)
    {
        string seriesNew = "";
        for (int i = 0; i < series.Length; i++)
        {
            if (series[i] != '')
            seriesNew = series[i];
        }
        return seriesNew;
    }

    void Checknumber2(int series)
    {
        if (series == '0' || series == '1' || series == '3'
        || series == '4' || series == '5' || series == '6'
        || series == '7' || series == '8' || series == '9'
        || series == '-')
        {
            System.Console.WriteLine("[]");
        }

        else
            System.Console.WriteLine($"Ошибка ввода символа. Вводи цифры");
    }

    int[] ArrayOfNumbers(string seriesNew)
    {
        int[] ArrayOfNumbers = new int[1];

        int j = 0;
        for (int i = 0; i < seriesNew.Length; i++)
        {
            string seriesNew1 = "";

            while (seriesNew[i]! = ',' && i < seriesNew.Length)
            {
                seriesNew1 = seriesNew[i];
                Checknumber2(seriesNew[i]);
                i++;
            }
            arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
            if (i < seriesNew.Length - 1)
            {
                arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
            }
            j++;
        }
        return arrayOfNumbers;
    }

    void PrintArray(int[] coll)
    {
        int count = coll.Length;
        int index = 0;
        System.Console.WriteLine("[");
        while (index < count)
        {
            System.Console.WriteLine(coll[index]);
            index++;
            if (index < count)
            {
                System.Console.WriteLine(", ");
            }
        }
        System.Console.WriteLine("]");
    }

    string seriesNew = RemovingSpaces(seriesOfNumbers);

    int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

    PrintArray(arrayOfNumbers);
}

