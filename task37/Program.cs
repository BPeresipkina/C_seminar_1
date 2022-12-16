// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Array(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadNumber("Введи число: ");
    }
    return array;
}

int length = ReadNumber("Введи длину массива: ");

int[] array = Array(length);

// Console.WriteLine(string.Join(", ", array));

int[] massiv = new int[array.Length / 2 + array.Length % 2];

for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = array[i] * array[array.Length - 1 - i];
    if (i == array.Length - 1 - i)
    {
        massiv[i] = array[i];
    }
}
Console.WriteLine(string.Join(", ", massiv));