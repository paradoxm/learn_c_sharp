// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);
PrintList(randomList);

int[] multed = MultPairs(randomList);

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
        list[index] = random.Next(1, 11);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int[] MultPairs(int[] list)
{
    int odd = list.Length % 2;
    int size = (list.Length / 2) + odd;
    int[] result = new int[size];

    for (int index = 0; index < size; index++)
    {
        int next = list.Length - index - 1;

        result[index] = next == index ? list[index] : list[index] * list[next];
    }

    return result;
}
