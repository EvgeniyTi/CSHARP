int num1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (num2 >= max && num2 >= num3)
{
    max = num2;
}
else if (num3 >= max && num3 >= num1)
{
    max = num3;
}

Console.WriteLine(max);