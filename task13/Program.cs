// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int div = 10;
int result = 0;
int i = 1;

while (number / div > 0)
{
    div = div * 10;
    i++;
}

// Console.WriteLine(i);

if (i > 2)
 {
     i = i - 3;
     div = 10;

     while (i > 0)
     {
         div = div * 10;
         i = i - 1;
     }

    //  Console.WriteLine(div);

     result = number % div / (div / 10);

     Console.WriteLine(result);
 }
 else
 {
     Console.WriteLine("Третьей цифры нет");
 }