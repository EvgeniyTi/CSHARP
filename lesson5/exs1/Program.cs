//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//1. создать массив
//2. заполнить массив
//3. посчитать количество четных чисел
//4. Распечатать


Console.Clear();

void Main(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"[{String.Join(",", array)}] -> {count}");
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Main(array);