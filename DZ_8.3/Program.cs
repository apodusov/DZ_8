// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("Введите количество строк m1");
int rows1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n1");
int columns1 = int.Parse(Console.ReadLine()!);

int[,] arrayA = new int[rows1, columns1];

Console.WriteLine("Введите количество строк m2");
int rows2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов n2");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] arrayB = new int[rows2, columns2];
int[,] arrayC = new int[rows1, columns2];
// Произведение двух матриц АВ имеет смысл только в том случае,
// когда число столбцов матрицы А совпадает с числом строк матрицы В .


FillArrayA(arrayA);
PrintArrayA(arrayA);
Console.WriteLine();

FillArrayB(arrayB);
PrintArrayB(arrayB);
Console.WriteLine();

ProductMatrix(arrayC);
PrintArrayC(arrayC);

void FillArrayA(int[,] arrayA)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            arrayA[i, j] = new Random().Next(1, 5);

        }
    }

}

void PrintArrayA(int[,] arrayA)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            Console.Write($"{arrayA[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillArrayB(int[,] arrayB)
{
    for (int i = 0; i < rows2; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            arrayB[i, j] = new Random().Next(1, 5);

        }
    }

}
void PrintArrayB(int[,] arrayB)
{
    for (int i = 0; i < rows2; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            Console.Write($"{arrayB[i, j],3} ");
        }
        Console.WriteLine();
    }
}


void ProductMatrix(int[,] arrayC)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum = arrayA[i, k] * arrayB[k, j] + sum;
            }
            arrayC[i, j] = sum;
        }
    }
}



void PrintArrayC(int[,] arrayC)
{
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            Console.Write($"{arrayC[i, j],3} ");
        }
        Console.WriteLine();
    }
}