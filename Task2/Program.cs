/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/ 

int[,] InitMatrix()
{
   int[,] array = new int[3,4];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-99,100);
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

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);
        
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не корректное число.");
        }
    }

    return result;
}

void NumberOfMatrix(int number, int[,] matrix)
{
    int line = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(number == matrix[i,j])
            {
                line = i+1;
                column = j+1; 
            }    
        }
    }
    if(line>0)
    {
        System.Console.Write($"Число {number} находится в {line} строчке и {column} столбце.");
    }
    else System.Console.Write($"Числа {number} нет в данном массиве.");
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
int number = GetNumber("Введите число: ");
NumberOfMatrix(number, matrix);

