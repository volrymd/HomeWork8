// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool CheckValue(int[] array, int number)
{
    foreach (int element in array)
    {
        if(element == number)
            return false;
    }
    return true;
}


void InputMatrix(int[,,] matrix, int [] array)
{
    int countNumbers = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                { 
                    matrix[i, j, k] = new Random().Next(10, 100); 
                    while (CheckValue(array, matrix[i, j, k]) == false)      
                        {
                            matrix[i, j, k] = new Random().Next(10, 100);
                        }
                    array[countNumbers] = matrix[i, j, k];
                    countNumbers++;
                }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
                Console.WriteLine();    
        }      
             
    }

}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
int[] helpArray = new int[size[0] * size[1] * size[2]];
InputMatrix(matrix, helpArray);
PrintMatrix(matrix);
