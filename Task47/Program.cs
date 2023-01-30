// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

void FillArray(double[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
    }
}

void PrintArray(double[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
FillArray(matrix, m, n);
PrintArray(matrix, m, n);



