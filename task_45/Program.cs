// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


int length = Propmpt("Введите длину массива: ");

int[] randomList = GenerateList(length);
PrintList(randomList);

int[] copy = CopyList(randomList);

randomList[0] = 200;
randomList[1] = 200;
PrintList(randomList);

Console.WriteLine();
PrintList(copy);




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
        list[index] = random.Next(1, 100);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int[] CopyList(int[] list)
{
    int[] result = new int[list.Length];

    for (int i = 0; i < list.Length; i++)
    {
        result[i] = list[i];
    }

    return result;
}
