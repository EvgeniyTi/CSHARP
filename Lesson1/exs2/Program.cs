int num1 = 22;
int num2 = 3;
int num3 = 9;
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