Console.Clear();

Console.Write("Введите 3х значное число: ");
string number = Console.ReadLine();
//Console.WriteLine(typeof(number));

if (number.Length >= 3 && int.Parse(number) > 0)
{
    Console.Write("Третья цифра ");
    Console.WriteLine(number[2]);
}
else if (int.Parse(number) < 0)
{
    Console.WriteLine("Введите положетельное число более 99 ");
}

else
{
    Console.WriteLine("третьей цифры нет");
}