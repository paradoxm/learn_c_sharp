// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] randomList = GenerateList(123);
PrintList(randomList);

int count = CountInRange(randomList, 10, 99);

Console.WriteLine();
Console.WriteLine($"Количество чисел в диапазоне [10,99]: {count}");




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
        list[index] = random.Next(-500, 500);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int CountInRange(int[] list, int from, int to)
{
    int result = 0;

    for (int index = 0; index < list.Length; index++)
    {
        if (list[index] >= from && list[index] <= to)
        {
            result += 1;
        }
    }

    return result;
}
