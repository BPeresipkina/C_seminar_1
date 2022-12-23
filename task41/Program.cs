// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

string number = "0";
int count = 0;
while (number != "stop")
{
Console.WriteLine("Введи число: ");
number = Console.ReadLine();
if (number != "stop")
{
int num = Convert.ToInt32(number);
if (num > 0) count++;
}
}
Console.WriteLine(count);