// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

(int, int) SumPositivAndNegativ(int[] array)
{
    int sumPlus = 0;
    int sumMinus = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
        {
            sumPlus += array[j];
        }
        else
        {
            sumMinus += array[j];
        }
    }
    return (sumPlus, sumMinus);
}

int length = 12;
int min = -9;
int max = 9;

int[] array = GetRandomArray(length, min, max);
Console.WriteLine(string.Join(", ", array));

(int sumP, int sumN) = SumPositivAndNegativ(array);
Console.WriteLine($"Сумма положительных элементов = {sumP}, сумма отрицательных элементов = {sumN}");