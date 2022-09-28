//Есть магазин "Еда"
//В магазине есть охранник
//Охранник ведёт запись всех, кто заходит в магазин
//Охранник ведёт запись всех, кто выходит из магазин
//Зайти и выйти можно в целый час.
//Выяснить в какой промежуток времени было больше всего
//посетителей
//Данные вводятся парами: приход-уход
//Максимум 100 покупателей
//Входные данные
////10-12
////11-13
//9-12
//Ответ
//11-12


// 1. создать массив из 3 интерваллов
//2. заполнить массив данными
//3. сумму всех элементов. 
//4. Находим разницу между 100 и нашей суммой
//5. если разница больше 0, то мы делим ее на 3 и отнимаем получившееся выражение из наших значений в массиве. И находим максимум
//6. если меньше, то просто находим максимум


Console.Clear();

string[] Times()
{
    string[] time = new string[3];

    for (int i = 0; i < 3; i++)
    {
        Console.Write($"Введите {i + 1} интервал: ");
        time[i] = Console.ReadLine();
    }

    return time;
}

double[] Use()
{
    double[] users = new double[3];

    int indexMax = 0;
    double max = users[indexMax];

    for (int i = 0; i < 3; i++)
    {
        users[i] = new Random().Next(1, 100);
        if (users[i] > max)
        {
            max = users[i];
            indexMax = i;
        }
    }

    return users;
}


int Maxxx(double[] users)
{
    int indexMax = 0;
    double max = users[indexMax];

    for (int i = 0; i < 3; i++)
    {
        if (users[i] > max)
        {
            max = users[i];
            indexMax = i;
        }
    }

    return indexMax;
}




//Console.WriteLine(String.Join(",", users));

void Main(string[] time, double[] users, int indexMax)
{
    if (users[0] + users[1] + users[2] > 100)
    {
        double dif = (users[0] + users[1] + users[2]) / 100;
        for (int i = 0; i < 3; i++)
        {
            users[i] /= dif;
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"В интервале {time[i]} было --> {Math.Round(users[i])}");
        }

        Console.WriteLine($"\nМаксимальное число посетителей было в интервале {time[indexMax]} часов -> {Math.Round(users[indexMax])}");
    }
    else
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"В интервале {time[i]} было --> {Math.Round(users[i])}");
        }

        Console.WriteLine($"\nМаксимальное число посетителей было в интервале {time[indexMax]} часов -> {Math.Round(users[indexMax])}");

    }
}

string[] t = Times();
double[] u = Use();
int index = Maxxx(u);
Main(t, u, index);