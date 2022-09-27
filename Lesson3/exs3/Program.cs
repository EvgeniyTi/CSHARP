Console.Clear();

void Result(int n)
{
    Console.Write($"Таблица кубов чисел от 1 до {n}: ");
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
}

Console.Write("Введите число (N): ");
int n = int.Parse(Console.ReadLine());
Result(n);