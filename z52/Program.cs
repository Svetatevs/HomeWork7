// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void Print2DArray(int[,] array)
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
Double[] SumColumn(int[,] array)
{
  int columnCount = array.GetLength(0);
  Double[] columnSum = new double[columnCount];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
      columnSum[j]=columnSum[j]+array[i,j];
        }
    }
  for (int j = 0; j < columnSum.GetLength(0); j++)
  {
    columnSum[j]=columnSum[j] / columnCount;
    Console.Write($"{columnSum[j]}, ");
  }
  Console.WriteLine();
    return columnSum;
}

int[,] array = CreateRandomArray(4, 4);
Print2DArray(array);
Double[] averageValues = SumColumn(array);
