// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// ​(в примере подсчет индексов начинается с 1 , как в математике)

// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] GetRandomArray(int line, int column, int min = 0, int max = 10)
{
    int[,] array = new int[line, column];
    Random rand = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SquareArrayPositivIngex(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i+=2)
{
    for(int j = 0; j < array.GetLength(1); j+=2)
    {
        array[i,j] *= array[i,j];
    }
}
}

int line = ReadNumber("Введи кол-во строк: ");
int column = ReadNumber("Введи кол-во столбцов: ");
int[,] massive = GetRandomArray(line, column);
PrintArray(massive);
Console.WriteLine();
SquareArrayPositivIngex(massive);
PrintArray(massive);