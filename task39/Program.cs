// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[] Array(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

int length = 5;// ReadNumber("Введи длину массива: ");
int min = 1;// ReadNumber("Введи минимальное число в массиве: ");
int max = 10;// ReadNumber("введи максимальное число в массиве: ");

int[] array = Array(length, min, max);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
Reverse(array);
Console.WriteLine($"[{string.Join(", ", array)}]");