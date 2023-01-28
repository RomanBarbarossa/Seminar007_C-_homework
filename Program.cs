// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double GetArray (int m , int n, int min,int mares)
//  {
//     double[,] res = new double[m,n];
    
//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             res[i,j] = Math.Round((new Random().NextDouble()),1);
//         }
//     }
//     return res;
//  }

// double[,] col = GetArray(4,4,0,10);


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine () !);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine ()!);

double[,] array = GetArray (rows, columns, -5, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] res = new double[m, n];
    for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                res[i, j] = Math.Round((new Random().NextDouble()),2);
            }
        }
        return res;
}


void PrintArray(double[,]col)
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