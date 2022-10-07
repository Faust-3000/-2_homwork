/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа. Решаем с помощью "/" и "%", со строками не работаем */

/* Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);

int num1 = number / 100;
int num2 = number / 10;
int num3 = num2 % 10;

Console.WriteLine(number);
Console.WriteLine($"{num3}"); */

/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Решаем с помощью "/" и "%", со строками не работаем 
(Максимальное число 100000) */

/* int number = new Random().Next(0, (100001));
Console.WriteLine(number);

if((number > 10000) || (number == 100000)) //10 тысяч до 100 тысяч
{
    int num1 = number / 100 % 10;
    Console.WriteLine($"{num1}");
}

else if((number > 1000) || (number == 10000)) // от тысячи до 10 тысяч
{
    int num2 = number / 10;
    int num3 = num2 % 10;
    Console.WriteLine($"{num3}");
}

else if((number > 100) || (number == 1000)) // от ста до тысячи
{
    int num4 = number % 10;
    Console.WriteLine($"{num4}");
}

else if((number < 99) || (number == 0)) // от нуля до ста
{
    Console.WriteLine("Третьей цифры нет");
} */


/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным. Обязательно сделать проверку на ввод чисел меньше 1 и больше 7 */

/* Console.WriteLine("Введите число");
int day = int.Parse(Console.ReadLine()!);

if((day == 6 ) || (day == 7))
{
    Console.WriteLine("Это выходной день");
}
else if((day == 1) || (day == 2) || (day == 3)
        || (day == 4) || (day == 5))
        {
            Console.WriteLine("Это будни, не выходной день");
        }
else if((day < 1) || (day > 7))
{
    Console.WriteLine("Это вообще не день недели");
} */
