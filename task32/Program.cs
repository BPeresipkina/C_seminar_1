// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Массивы к задачам 32 и 33 можно сделать рандомными.

int[] RandomArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int[] array = RandomArray(4, -8, 8);

Console.WriteLine(string.Join(", ", array));

for(int i = 0; i<array.Length; i++)
{
    array[i] *= -1;
}

Console.WriteLine(string.Join(", ", array));