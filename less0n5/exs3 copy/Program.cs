//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//1. создать массив 
//2. заполнить массив вещественными числами
//3. найти разницу между минимальным и максимвльным чимслом
//4. Распечатать


Console.Clear();

// Задаем и заполняем массив
double[] Arr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }

    return array;
}


// Ищим максимальное число
double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }


    return max;
}

// Ищим минимальное число
double Min(double[] array)
{
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

void Main()
{
    Console.Write("Задайте размер массива: ");
    int size = int.Parse(Console.ReadLine());
    double[] array = new double[size];

    double[] arr = Arr(array);

    double max = Max(arr);
    double min = Min(arr);

    Console.WriteLine($"[{String.Join(",", arr)}] -> {max - min}");
}

Main();