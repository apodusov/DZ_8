// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк m");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
FindElementArray(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);

        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] array)

{
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        sum2 = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = array[i, j] + sum;
        }
        if (sum2 < sum1)
        {
            sum = sum2; index = i;
        }
        sum1 = sum2;
    }

    Console.WriteLine($"номер строки с наименьшей суммой элементов:{index + 1} строка");
    Console.WriteLine();
}