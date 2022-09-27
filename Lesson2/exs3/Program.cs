Console.Clear();

Console.WriteLine("Введите число обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());


if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.Write("Сегодня выходной? - ДА");
    }
    else
    {
        Console.Write("Сегодня выходной? - НЕТ");
    }
}
else
{
    Console.WriteLine("Введите число в диапозоне от 1 до 7");
}
