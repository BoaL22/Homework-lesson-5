/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/

int[] array;
Console.WriteLine("Введите количество элементов массива: ");
array = new int[Convert.ToInt32(Console.ReadLine())];

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]}");
        if (i == array.Length - 1) Console.Write(" ]");
        else Console.Write(", ");
    }
    Console.WriteLine();
}

void SumEvenNumberArray(int[] array)
{
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + array[i];
            }

            if (array.Length - 1 == i)
            {
                Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
            }
        }

    Console.WriteLine();
}


ShowArray(array);
SumEvenNumberArray(array);
