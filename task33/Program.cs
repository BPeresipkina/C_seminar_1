// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными. 
// В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

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
int[] array = RandomArray(5, 0, 998);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i <= array.Length)
{
    if (i < array.Length)
    {
        if (array[i] == number)
        {
            Console.WriteLine("Да");
            break;
        }
        else { i++; }
    }
    else
    {
        Console.WriteLine("Нет");
        break;
    }
}