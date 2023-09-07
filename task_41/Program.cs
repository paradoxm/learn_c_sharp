// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int length = Propmpt("Введите длину массива: ");

int[] numbers = ReadNumbers(length);
int countPositiveNumbers = CountPositiveNumbers(numbers);

PrintList(numbers);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0: {countPositiveNumbers}");



int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


int[] ReadNumbers(int count)
{
    int[] list = new int[count];

    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");

        var number = Convert.ToInt32(Console.ReadLine());
        list[i] = number;
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int CountPositiveNumbers(int[] list)
{
    int count = 0;

    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > 0)
        {
            count++;
        }

    }

    return count;
}
