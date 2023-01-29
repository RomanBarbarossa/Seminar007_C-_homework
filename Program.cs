// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine () !);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine ()!);

// double[,] array = GetArray (rows, columns, -5, 10);
// PrintArray(array);

// // ____________-----Methods-----______________
// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] res = new double[m, n];
//     for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < m; j++)
//             {
//                 res[i, j] = Math.Round((new Random().NextDouble()),2);
//             }
//         }
//         return res;
// }


// void PrintArray(double[,]col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             Console.Write($"{col[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// ---------------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает число,и проверяет есть ли 
// такое число в двумерном массиве, а также возвращает сообщение о том,что оно найдено 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// ____________-----Methods-----______________

//           __1__  создание массива
// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] res = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             res[i, j] = new Random().Next(min, max - 1);
//         }
//     }
//     return res;
// }
// //          __2__ печать данного массива
// void PrintArray(int[,] col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             Console.Write($"{col[i, j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// // __3__ нахождение нужного значения в данном массиве

// void GetNumFromArray(int[,] array, int find)
// {
//     bool IsHere = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == find) IsHere = true;
//         }
//     }
//     if (IsHere == true)
//     {
//         Console.WriteLine("Число есть в массиве");
//     }
//     else Console.WriteLine("Числа нет в массиве");
// }

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] ourArray = GetArray(m, n, -5, 23);
// PrintArray(ourArray);

// Console.Write("Введите искомое число: ");
// int find = int.Parse(Console.ReadLine()!);

// GetNumFromArray(ourArray, find);


// ---------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// ____________-----Methods-----______________

//           __1__  создание массива
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(min, max - 1);
        }
    }
    return res;
}
//          __2__ печать данного массива
void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]}  ");
        }
        Console.WriteLine();
    }
}

//          __3__ нахождение среднего арифметического в СТОЛБЦЕ

void AverageInColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn = sumColumn + array[j, i];
        }
        Console.Write(Convert.ToDouble(sumColumn / array.GetLength(0)) + " |");
    }

}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(m, n, -12, 23);
PrintArray(Array);
Console.WriteLine();
AverageInColumn(Array);