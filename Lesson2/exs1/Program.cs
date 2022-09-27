Console.Clear();

Console.WriteLine("Введите 3х значное число: ");
int number = int.Parse(Console.ReadLine());


if (number > 99 && number < 1000)
{
    Console.WriteLine("Вторая цифра ");
    Console.WriteLine(number / 10 % 10);
}
else
{
    Console.WriteLine("Введите положительное 3х число!!!");
}



