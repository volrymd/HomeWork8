// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindSum (int [,] matrix, int [] array)
{
    int k = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
           for(int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix [i,j];
            }
            array[k] = sum;
            k++;                     
        }
Console.WriteLine($"Результат суммы в каждой стоке: [{string.Join(", ", array)}]");      
}

int FindMinSum (int [] array)
{
    int min = array [0];
    int minIndex = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) 
            {
                min = array [i];
                minIndex = i;
            }
    }
return minIndex;    
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] helpArray = new int[size[0]];
InputMatrix(matrix);
PrintMatrix(matrix);
FindSum (matrix, helpArray);
int minimum = FindMinSum (helpArray);
Console.WriteLine($"Минимальная сумма в сторке под номером {minimum + 1}");

