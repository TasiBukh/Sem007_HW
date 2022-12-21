// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введи m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введи n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];

CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.WriteLine(alignNumber + " ");
        }
        Console.WriteLine();
    }
}