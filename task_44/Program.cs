// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int number = Propmpt("Введите число: ");

int[] fibonachiNUmbers = FibonachiNUmbers(number);

PrintList(fibonachiNUmbers);



int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int[] FibonachiNUmbers(int number)
{
    int[] result = new int[number];

    if (number <= 1){
        return result;
    }

    result[1] = 1;

    for (int i = 2; i < number; i++)
    {
        result[i] = result[i - 2] + result[i - 1];
    }

    return result;
}
