// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[]CreateArray(int size)
// {
//   int[] myArray = new int[size];
//   for (int i = 0; i < size; i++)
//       {
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         myArray[i] = Convert.ToInt32(Console.ReadLine());
//       }
//       return myArray;
// }
// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив:");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindNum(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//            {
//             count++;
//             }
//     }
//     Console.WriteLine($"Количество чисел больше нуля {count}");
// }

// Console.WriteLine("Введите размер массива:");
// int Length = Convert.ToInt32(Console.ReadLine());
// int[] newarray = CreateArray(Length);
// ShowArray(newarray);
// FindNum(newarray);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Tochki (double a1, double c1, double a2, double c2)
{
    double x = (-a2 + a1)/(-c1 + c2);
    double y = c2 * x + a2;
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Tochki(b1, k1, b2, k2);