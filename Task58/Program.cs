// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0,11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        
        Console.WriteLine();
    }
}

void ChangeMatrix (int [,] matrix1, int [,] matrix2)
{
    int i = 0;
            for (int k = i; k < matrix2.GetLength(0); k++)
            {
                int j = 0; 
                for (int l = j; l < matrix1.GetLength(1); l++)
                {
                    matrix2[k,l] *= matrix1[i,j];
                    j++;
                    Console.Write($"{matrix2[k, l]}\t"); 
                }
                i++;
            Console.WriteLine();
            }
}


Console.Clear();
Console.WriteLine("Введите размеры массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
int [,] matrix2 = new int [size[0], size[1]];
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine("\n\n");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine("\n\n");
ChangeMatrix (matrix1, matrix2);