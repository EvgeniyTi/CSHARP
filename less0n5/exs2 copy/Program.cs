//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//1. создать массив
//2. заполнить массив
//3. посчитать сумму элементов стоящих на нечетных позициях
//4. Распечатать


Console.Clear();

void Main(double[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
        if (i % 2 != 0) sum = sum + array[i];
    }
    Console.WriteLine($"[{String.Join(",", array)}] -> {sum}");
}

Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
Main(array);