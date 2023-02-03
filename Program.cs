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

______________________________________________________
// Задача 50. Напишите программу, которая на вход принимает число, 
// и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, 
// что оно найдено или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// __methods

// int GetArray (int m , int n, int min,int max)
//  {
//     int[,] res = new int[m,n];

//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             res[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return res;
//  }

// void PrintArray(int[,]col)
// {
//     for (int i = 0; i < col.GetLength(0); i++)
//     {
//         for (int j = 0; j < col.GetLength(1); j++)
//         {
//             Console.Write($"[{String.Join("|",col)}]");
//         }
//         Console.WriteLine();
//     }
// }

//  bool FindInArray (int[,]array, int find)
//  {
//     int[,]collection = new int[7,7];
//     foreach (int i in collection)
//     {
//         if(i == find) return true;
//         else return false;
//     }
//  }

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine () !);
// Console.Write("Введите количество строк массива: ");
// int n = int.Parse(Console.ReadLine () !);

// int[,]massive = GetArray(m,n,)


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
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
// // _________-----Methods-----___________
// double[,] GetArray(int m, int n, int min, int max)
// {
// double[,] res = new double[m, n];
// for (int i = 0; i < n; i++)
// {
// for (int j = 0; j < m; j++)
// {
// res[i, j] = Math.Round((new Random().NextDouble()),2);
// }
// }
// return res;
// }
// void PrintArray(double[,]col)
// {
// for (int i = 0; i < col.GetLength(0); i++)
// {
// for (int j = 0; j < col.GetLength(1); j++)
// {
// Console.Write($"{col[i, j]} ");
// }
// Console.WriteLine();
// }
// }



// **Задача 65:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


// Console.Write("Введи начальное число: ");
// int M  = int.Parse(Console.ReadLine()!);

// Console.Write("Введи конечное число: ");
// int N  = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(M,N));

// // ------------------Метод------------------
// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }



// ________________________________________________________
// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9


// Console.Write("Введи число: ");
// int number  = int.Parse(Console.ReadLine()!);

// Console.WriteLine(GetSum(number));

// int GetSum (int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + GetSum (number / 10));
// }

// ________________________________________________________
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)

// A = 2; B = 3 -> 8


// int Pow (int A, int B)
// {
//     if(B == 0) return 1;
//     if(B == 1) return A;
//     return (A * Pow(A,B-1));
// }

// Console.Write("Введи число: ");
// int A  = int.Parse(Console.ReadLine()!);

// Console.Write("Введи степень: ");
// int B  = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine(Pow(A,B));



// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент. 

// ___________________________Methods______________________________


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]");
        }
        Console.WriteLine();

    }
}

// поиск индекса СТРОКИ минимального значения всего массива

int MinI(int[,] array)
{
    int minI = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minI = i;
            }
        }
       ;
    }
    return minI;
}

// поиск индекса СТОЛБЦА минимального значения всего массива

int MinJ(int[,] array)
{
    int minJ = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minJ = j;
            }
        }
    }
    return minJ;
}
           
//  новый массив без одной строки и столбца на пересечении
//  которых находится минимальный элемент

int[,] NewArray(int[,] Array, int minI, int minJ)      
{
    int[,] newArray = new int[Array.GetLength(0) - 1, Array.GetLength(1) - 1];
    int rows = 0;
    int columns = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if(i == minI) continue;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if(j == minJ) continue;
            newArray[rows,columns] = Array[i, j];
            columns++;
        }
        rows++;
        columns = 0;
    }
    return newArray;
}

Console.Write("Enter a number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 8);
PrintArray(array);
int minI = MinI(array);
int minJ = MinJ(array);
System.Console.WriteLine($"min index row is {minI} , min index column is {minJ}");
System.Console.WriteLine();
int[,] newArray = NewArray(array, minI, minJ);
PrintArray(newArray);
