//Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.;
//14212->нет;
//12821->да;
//23432->да;


Console.Clear();


void Number(string num)
{
    if (num[0] != num[4]) Console.WriteLine("НЕТ");
    else Console.WriteLine("ДА");
}

Console.Write("Введите 5ти значное число: ");
string num = Console.ReadLine();
Console.Write("Число является палиндромом? ");
Number(num);