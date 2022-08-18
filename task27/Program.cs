// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

long cutFromRight(long num)
{
    return num / 10;
}

long getRightDigit(long num)
{
    return num % 10;
}

Console.WriteLine("Введите число");
long num = Math.Abs(Convert.ToInt64(Console.ReadLine()));

long summ = 0;

while (num >= 10) {
    summ += getRightDigit(num);
    num = cutFromRight(num);
}

summ += num;

Console.WriteLine("Сумма цифр в числе: " + summ);
