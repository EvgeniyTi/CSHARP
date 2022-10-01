Console.Clear();


void Points(double[] pointA, double[] pointB)
{
    Console.WriteLine($"Расстояние между точками А и B равно {Math.Round(Math.Sqrt((Math.Pow(pointB[0] - pointA[0], 2)) + (Math.Pow(pointB[1] - pointA[1], 2)) + (Math.Pow(pointB[2] - pointA[2], 2))), 2)}");
}

//Points((3.0, 6.0, 7.0), (2.0, 1.0, -7.0));

void Main()
{
    double[] pointA = { 7, 6, -1 };
    double[] pointB = { 1, 0, -1 };

    Points(pointA, pointB);

}

Main();

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//Вариант 2

//Console.Clear();


//void Points()
///{
//    string[] arraya = { "x", "y", "z" };
//    Console.WriteLine("Координаты точки A ");
//    double[] arrayA = new double[3];

//    for (int i = 0; i < 3; i++)
//    {
//        Console.Write($"Введите число для ординаты {arraya[i]}: ");
//        arrayA[i] = double.Parse(Console.ReadLine());
//    }

//    Console.WriteLine();
//    Console.WriteLine("Координаты точки B ");
//    double[] arrayB = new double[3];

//    for (int i = 0; i < 3; i++)
//    {
//        Console.Write($"Введите число для ординаты {arraya[i]}: ");
//        arrayB[i] = double.Parse(Console.ReadLine());
//    }

//    Console.WriteLine();
//    Console.WriteLine($"Координаты точки A({arrayA[0]}, {arrayA[1]}, {arrayA[2]})");
//    Console.WriteLine($"Координаты точки B({arrayB[0]}, {arrayB[1]}, {arrayB[2]})");

//    Console.WriteLine();
//    Console.WriteLine($"Расстояние между точками А и B равно {Math.Round(Math.Sqrt((Math.Pow(arrayB[0] - arrayA[0], 2)) + (Math.Pow(arrayB[1] - arrayA[1], 2)) + (Math.Pow(arrayB[2] - arrayA[2], 2))), 2)}");
//}

//Points();