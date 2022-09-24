/*
    Задача 34: 
    Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2
*/

int[] array;
Console.WriteLine("Введите количество элементов массива: ");
array = new int[Convert.ToInt32(Console.ReadLine())];

void Array(int[] array)
{
    Console.WriteLine();

        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(new Random().Next(100,1000));
            Console.Write($"{array[i]}");

                if (i == array.Length - 1) Console.Write(" ]");
                else Console.Write(", ");
        }
}

void ShowArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine();

        for (int a = 0; a < array.Length; a++) 
        {
            if (array[a] % 2 == 0) 
            {
                Console.WriteLine($"{array[a]} - чётное число");
            }
            else
            {
                Console.WriteLine($"{array[a]} - не чётное число");
            }
        }
}

void NumberEvenArray(int[] array)
{
        int even = 0;
        for (int b = 0; b < array.Length; b++) 
        {
            if (array[b] % 2 == 0)  even++;
            else    b++;
        }

    Console.WriteLine();
    Console.WriteLine($"В данном массиве {even} чётных чисел.");
    Console.WriteLine();
}


Array(array);
ShowArray(array);
NumberEvenArray(array);
