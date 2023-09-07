// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x +
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double factorB1 = Propmpt("Введите коэффициент b1: ");
double factorK1 = Propmpt("Введите коэффициент k1: ");
double factorB2 = Propmpt("Введите коэффициент b2: ");
double factorK2 = Propmpt("Введите коэффициент k2: ");

if (hasIntersactions(factorB1, factorK1, factorB2, factorK2))
{
    double[] point = IntersectionPoint(factorB1, factorK1, factorB2, factorK2);

    string equationsMessage = EquationsMessage(factorB1, factorK1, factorB2, factorK2);

    Console.Write($"Точка пересечения для уравнений {equationsMessage} равна: ");
    double[] roundedPoint = RoundArray(point, 2);
    PrintList(roundedPoint);
}



double Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    double result = Convert.ToDouble(input);
    return result;
}

void PrintList(double[] list)
{
    string joinedList = string.Join(", ", list);

    Console.WriteLine($"[{joinedList}]");
}


bool hasIntersactions(double b1, double k1, double b2, double k2)
{
    bool isConstEqual = k1 == k2;
    bool isFactorEqual = b1 == b2;

    string equationsMessage = EquationsMessage(b1, k1, b2, k2);

    if (isConstEqual && isFactorEqual)
    {
        Console.WriteLine($"Линии для уравнений {equationsMessage} полностью совпадают.");
        return false;
    };

    if (isConstEqual)
    {
        Console.WriteLine($"Линии для уравнений {equationsMessage} параллельные.");
        return false;
    };

    return true;
}

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    result[0] = x;
    result[1] = y;

    return result;
}

string EquationsMessage(double b1, double k1, double b2, double k2)
{
    return $"y={k1}*x + {b1}, y={k2}*x + {b2}";
}

double[] RoundArray(double[] list, int presition)
{
    double[] roundedList = new double[list.Length];

    for (int index = 0; index < roundedList.Length; index++)
    {
        roundedList[index] = Math.Round(list[index], presition);
    }

    return roundedList;
}