// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void setValue(int[] arr, int index)
{
    Console.WriteLine("Введите значение элемента массива под индексом " + index);
    arr[index] = Convert.ToInt32(Console.ReadLine());
}

int[] arr = new int[8];
for (int index = 0; index < arr.Length; index++) {
    setValue(arr, index);
}
string output = $"[{arr[0]}";
for (int index = 1; index < arr.Length - 1; index++) {
    output += $", {arr[index]}";
}
output += $", {arr[7]}]";

Console.WriteLine("Массив: " + output);
