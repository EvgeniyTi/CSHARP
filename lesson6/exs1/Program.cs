//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


Console.Clear();

void Main(string args)
{
    string[] numbers = args.Split(',');

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (Convert.ToInt64(numbers[i]) > 0) count++;
    }
    //Console.WriteLine(String.Join(",", numbers));
    Console.Write($"Колличество чисел больше нуля равно --> {count}");
}

Console.Write("Ввведите с клавиатуры набор чисел: ");
Main(Console.ReadLine());