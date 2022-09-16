// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (isNumberM != true || isNumberN != true)
{
    Console.WriteLine("Число введено неверно.");
}
double[,] array = new double[m, n];
CreateArray(m, n);
Print2DArray(array);
double CreateArray(int m, int n)
{
    // double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(-10, 10)) / 10;
        }
    }
    return array[0, 0];
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

