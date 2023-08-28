// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);

PrintList(randomList);


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
        list[index] = random.Next(0, 100);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}