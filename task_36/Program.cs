// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);
PrintList(randomList);

int sumOddPosition = SumOddPosition(randomList);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddPosition}");




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


int SumOddPosition(int[] list)
{
    int sum = 0;

    for (int index = 1; index < list.Length; index+=2)
    {
        sum += list[index];
    }

    return sum;
}
