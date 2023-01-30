// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void FillArray(int[,] matrix, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(int[,] matrix, int m, int n)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
            sum = sum + matrix[i, j];
        }
        Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое = {sum / n}");
    }
}



Console.WriteLine("Введите количество строк  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix, m, n);
PrintArray(matrix, m, n);