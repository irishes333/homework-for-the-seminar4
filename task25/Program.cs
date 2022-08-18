// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

long power(long baseNum, long exponent)
{
    if (exponent < 2)
    {
        return baseNum;
    }
    else
    {
        return baseNum * power(baseNum, exponent - 1);
    }
}

Console.WriteLine("Введите число A");
long numA = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число B");
long numB = Convert.ToInt64(Console.ReadLine());

if (numB < 1)
{
    Console.WriteLine("Некорректное значение");
}
else
{
    Console.WriteLine("число A в степени числа B: " + power(numA, numB));
}
