/* Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран. 
Задание должно быть выполнено в методах.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] numbers = new int[12];

FillArray(numbers);
PrintArray(numbers);

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
}