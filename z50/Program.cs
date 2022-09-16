// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента
Console.WriteLine("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
if (isNumberM != true || isNumberN != true)
{
    Console.WriteLine("Число введено неверно.");
}

Console.WriteLine("Введите число: ");
bool isNumN = int.TryParse(Console.ReadLine(), out int N);

if (isNumN == false)
{
    Console.WriteLine("Введены неправильные данные.");
}

int[,] array = CreateRandomArray(m, n);

FindIndex(m, n);

Print2DArray(array);

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

int[,] FindIndex(int m, int n)
{
    bool notFind = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (N == array[i, j])
            {
                notFind = false;
                Console.WriteLine($"Индекс i - {i}");
                Console.WriteLine($"Индекс j - {j}");
            }
        }
    }
    if (notFind)
    {
        Console.WriteLine("Такого числа нет в массиве.");
    }
    return array;
}
