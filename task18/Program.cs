// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("Значения координат в первой четверти: X > 0, Y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("Значение координат во второй четверти: X < 0, Y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("Значение координат в третьей четверти: X < 0, Y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("Значение координат в четвертой четверти: X > 0, Y < 0");
}
else 
{
    Console.WriteLine("Такой координатной четверти не существует");
}