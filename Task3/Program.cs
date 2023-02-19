/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/ 

int[,] InitMatrix()
{
   int[,] array = new int[3,4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0,10);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}  ");
        }
        System.Console.WriteLine();
    }
    
}

void ArithmeticalMean(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)   
        {
            sum = sum + matrix[i,j];
        }
        sum = sum/matrix.GetLength(0);
        System.Console.Write($"Среднее арифметическое {j+1} столбца: {sum:0.##}; ");
    }
    
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
ArithmeticalMean(matrix);

