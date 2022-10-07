/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем */

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);

int num1 = number / 100;
int num2 = number / 10;
int num3 = num2 % 10;

Console.WriteLine(number);
Console.WriteLine($"{num3}");