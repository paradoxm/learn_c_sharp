Console.WriteLine("Необходимо ввести 3-и числа, среди которых найдем максимальное");
List<int> numbers = ReadNumbers(3);
int maxNumber = GetMax(numbers);

Console.WriteLine($"Максимальное число: {maxNumber}");



List<int> ReadNumbers(uint count)
{
    List<int> list = new List<int>();

    for (int index = 0; index < count; index++)
    {
        Console.Write($"Введите {index + 1}-е число: ");

        var number = Convert.ToInt32(Console.ReadLine());
        list.Add(number);
    }

    return list;
}

int GetMax(List<int> numbers)
{
    int maxNumber = numbers[0];

    for (int i = 0; i < numbers.Count; i++)
    {
        if (maxNumber < numbers[i])
        {
            maxNumber = numbers[i];
        }

    }

    return maxNumber;
}