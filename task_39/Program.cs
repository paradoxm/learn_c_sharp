// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);
PrintList(randomList);

int[] multed = Reverse(randomList);

Console.WriteLine();
PrintList(multed);




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


int[] Reverse(int[] list)
{
    int[] result = new int[list.Length];

    for (int i = 0; i < list.Length; i++)
    {
        result[i] = list[i];
        result[i] = list[list.Length - i - 1];
    }

    return result;
}
