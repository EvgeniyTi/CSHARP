Console.Clear();

int count = 7;
int sum = 0;
int index = 0;
int[] array = new int[count];

Console.Write("Введенные семь чисел: ");
while (index < count)
{
    array[index] = new Random().Next(1, 100);
    sum += array[index];
    Console.Write(array[index] + " ");
    index++;
}

int average = sum / count;
Console.WriteLine($"\nСреднее арифметическое значение равно  --> {average}");

