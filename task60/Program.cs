// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetRandomArray(int line = 2, int column = 2, int width = 2, int min = 10, int max = 99)
{
    int[,,] array = new int[line, column, width];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < width; k++)
            {
                array[i, j, k] = rand.Next(min, max + 1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = GetRandomArray();

Console.WriteLine();
PrintArray(array);
Console.WriteLine();