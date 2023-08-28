// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Необходимо ввести координаты первой точки в 3D пространсве");
int[] point1 = ReadNumbers(3);

Console.WriteLine("Необходимо ввести координаты второй точки в 3D пространсве");
int[] point2 = ReadNumbers(3);

double distance = Distance(point1, point2);

PrintResult(point1, point2, distance);



int[] ReadNumbers(uint count)
{
    int[] list = new int[3];

    for (int index = 0; index < count; index++)
    {
        Console.Write($"Введите {CoordName(index)}: ");

        var number = Convert.ToInt32(Console.ReadLine());
        list[index] = number;
    }

    return list;
}


string PointToString(int[] point)
{
    return string.Join(",", point);
}


string CoordName(int index)
{
    switch (index)
    {
        case 0: return "X";
        case 1: return "Y";
        case 2: return "Z";

        default: return "Unknown";
    };
}


double Distance(int[] firstPoint, int[] secondPoint)
{
    int x = firstPoint[0] - secondPoint[0];
    int y = firstPoint[1] - secondPoint[1];
    int z = firstPoint[2] - secondPoint[2];

    return Math.Sqrt(x * x + y * y + z * z);
}


void PrintResult(int[] firstPoint, int[] secondPoint, double distance)
{
    double rounded = Math.Round(distance, 2);
    string point1Str = PointToString(firstPoint);
    string point2Str = PointToString(secondPoint);

    Console.WriteLine($"Расстояние между [{point1Str}] и [{point2Str}]: {rounded}");
}