// тип_метода ИмяМетода (пар1, пар2, ... парN)
// int Calculate (int a, int b, string sign) // a & b - 2 numbers, sign - arithmetic sign
// {
//     if (sign == "+")
//     {
//         return a + b; // sum of these numbers
//     }
//     else if (sign == "-")
//     {
//         return a - b; 
//     }
//     else if (sign == "*")
//     {
// return a * b;         
//     }
//     else 
//     {
//         Console.WriteLine("An unknown sign was entered");
//         return 0;
//     }
// }

// // Вызов метода

// Console.WriteLine(Calculate(2, 3, "+"));
// Console.WriteLine(Calculate(2, 3, "-"));
// Console.WriteLine(Calculate(20, 3, "*"));
// Console.WriteLine(Calculate(2, 3, "."));

// Задайте массив из N случайных чисел. Найдите количество 
// чисел, которые оканчиваются на 1 и делятся нацело на 7
// Пример [1 5 11 21 81 4 0 91 2 3] => 2

// int[] CreateArray (int size)
// {
//     int[] array = new int[size]; // массив на size элементов 
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 101); // 1...100 (0, 5 => 0, 1, 2, 3, 4 except for 5)
//         // int.minValue or int.maxValue == to find out the min and man values of the int type
//     } 
//     return array;
// }

// // Вызов метода
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Результат: {GetCount(res)}");

// int GetCount(int[ ] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 7 == 0 && arr[i] % 10 == 1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9. Сформируйте целое число,
// которое будет состоять из цифр из массива. Старший разряд 
// числа находится на 0-м индексе, младший на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray (int size)
 {
     int[] array = new int[size]; // массив на size элементов 
     for (int i = 0; i < array.Length; i++)
     {
         array[i] = new Random().Next(10); // [0, 9]
     } 
     return array;
 }

 int ConvertArrayToInteger(int[] array)
 {
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        result = result + array[i] * (int)Math.Pow(10, j); // Math.Pow yields a double, hence, we convert to int
        // 10 - number, j - power 
    }
    return result;
 }

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
 int[] res = CreateArray(N); // Создали массив на N элементов
 Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
 Console.WriteLine($"Результат: {ConvertArrayToInteger(res)}");