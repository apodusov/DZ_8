//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк m");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();

CreateNewArray(array);


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

void СhangeArray(int[,] array)

{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])

                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }

}

void CreateNewArray(int[,] array)
{
    int[,] row = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {

        for (int j = 0; j < columns; j++)
        {
            row[i, j] = array[i, j];
            СhangeArray(array);
        }

    }
    PrintArray(array);
    Console.WriteLine();

}