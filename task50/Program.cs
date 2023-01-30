// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}




Console.WriteLine("Введите количество строк  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArray(matrix, m, n);
PrintArray(matrix, m, n);

Console.WriteLine("Введите номер строки  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца  ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > m && b > n)
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine(matrix[a-1,b-1]);
}

