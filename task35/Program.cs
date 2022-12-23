// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int length = 123; //ReadNumber("Введи длину массива: ");
int min = 0; //ReadNumber("Введи минимальное число в массиве: ");
int max = 150; //ReadNumber("Введи максимальное число в массиве: ");

int[] array = Array(length, min, max);

Console.WriteLine(string.Join(", ", array));

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        j++;
    }
}

if (j == 0) Console.WriteLine("В массиве нет чисел от 10 до 99");
else Console.WriteLine($"В массиве {j} чисел от 10 до 99");