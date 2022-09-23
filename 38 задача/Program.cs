/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите количество элементов массива: ");
int index = Convert.ToInt32(Console.ReadLine());
double[] array = new double[index];

void MinMax(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int a = 0; a < array.Length; a++)
    {
        if (array[a] > max)
        {
            max = array[a];
        }
        if (array[a] < min)
        {
            min = array[a];
        }
    }
    Console.WriteLine($"Минимальное число массива = {min}");
    Console.WriteLine($"Максимальное число массива = {max}");
    Console.WriteLine($"Разница между ними = {max - min}");
}

void ShowArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1,1000)) / 100;
        Console.Write($"{array[i]}");
        if (i == array.Length - 1) Console.Write(" ]");
        else Console.Write(", ");
    }
    Console.WriteLine();
}

ShowArray(array);
MinMax(array);