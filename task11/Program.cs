// Напиши программу, которая выводит случайное трехзначноее число и удаляет вторую цифру этого числа
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int digit3 = number % 10;
int digit1 = number / 100;

int result = digit1 * 10 + digit3;

Console.WriteLine($"Случайное число = {number}, готовое число = {result}");