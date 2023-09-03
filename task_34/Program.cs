// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);
PrintList(randomList);

int countOfEven = CountOfEven(randomList);

Console.WriteLine($"Количество чётных чисел в массиве: {countOfEven}");




int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


int[] GenerateList(int count)
{
    int[] list = new int[count];
    Random random = new Random();

    for (int index = 0; index < count; index++)
    {
        list[index] = random.Next(100, 1000);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int CountOfEven(int[] list)
{
    int count = 0;

    for (int index = 0; index < list.Length; index++)
    {
        if (list[index] % 2 == 0)
        {
            count += 1;
        }
    }

    return count;
}
