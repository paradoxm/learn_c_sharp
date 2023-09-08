// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



uint length = Propmpt("Введите длину массива:");

if (length > 0)
{
    double[] randomList = GenerateList(length);
    double[] roundedList = RoundArray(randomList, 2);

    PrintList(roundedList);

    double minNumber = Min(roundedList);
    double maxNumber = Max(roundedList);
    double result = maxNumber - minNumber;

    Console.WriteLine($"Разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами массива: {result}");
}
else
{
    Console.WriteLine($"Массив пустой.");
}



uint Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    uint result = Convert.ToUInt32(input);
    return result;
}


double[] GenerateList(uint count)
{
    double[] list = new double[count];
    Random random = new Random();
    double from = 1.0;
    double to = 100.0;

    for (int index = 0; index < count; index++)
    {
        list[index] = random.NextDouble() * (to - from) + from;
    }

    return list;
}


void PrintList(double[] list)
{
    string joinedList = string.Join(", ", list);

    Console.WriteLine($"[{joinedList}]");
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

double Max(double[] list)
{
    double maxNumber = list[0];

    for (int i = 0; i < list.Length; i++)
    {
        if (maxNumber < list[i])
        {
            maxNumber = list[i];
        }

    }

    return maxNumber;
}

double Min(double[] list)
{
    double minNumber = list[0];

    for (int i = 0; i < list.Length; i++)
    {
        if (minNumber > list[i])
        {
            minNumber = list[i];
        }

    }

    return minNumber;
}
