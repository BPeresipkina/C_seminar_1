//  Составить частотный словарь элементов двумерного массива. 
//  Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] GetRandomArray(int line, int column, int min = 0, int max = 9)
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

// int min = array[0, 0];
// int max = array[0, 0];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (min > array[i, j])
//         {
//             min = array[i, j];
//         }
//         else if (max < array[i, j])
//         {
//             max = array[i, j];
//         }
//     }
// }

// Console.WriteLine(min + ", " + max);
// Console.WriteLine();

// int count = 0;
// for (int n = min; n <= max; n++)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (n == array[i, j])
//             {
//                 count ++;
//             }
//         }
//     }
//     if (count>0)
//     {
//     Console.WriteLine($"{n} встречается {count} раз(а)");
//     count = 0;
//     }
// }

void PrintRepets(int[,] matr)
{
    int[] counters = new int[10];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            counters[matr[i, j]]++;
        }
    }

    for (int i = 0; i < counters.Length; i++)
    {
        if (counters[i] > 0)
        {
            Console.WriteLine($"Элемент {i} повторяется {counters[i]} раз(а)");
        }
    }

}

int line = ReadNumber("Введи кол-во строк: ");
int column = ReadNumber("Введи кол-во столбцов: ");

int[,] array = GetRandomArray(line, column);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintRepets(array);