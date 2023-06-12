// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void InputMatrix(int[,] matrix)
{
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = start;
        start++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
