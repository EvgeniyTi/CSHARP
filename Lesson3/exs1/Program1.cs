//Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.;
//14212->нет;
//12821->да;
//23432->да;


Console.Clear();


// Вариант №1

void Number(int num)
{
    int[] arr = new int[5];

    for (int i = 0; i < 5; i++)
    {
        arr[i] = num % 10;
        num /= 10;
    }
    if (arr[0] != arr[4]) Console.WriteLine("НЕТ");
    else Console.WriteLine("ДА");
}

Console.Write("Введите 5ти значное число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Число является палиндромом? ");
Number(num);