// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);

PrintList(randomList);

int[] inderted = Invert(randomList);

PrintList(inderted);




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
        list[index] = random.Next(-9, 10);
    }

    return list;
}


void PrintList(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}


int[] Invert(int[] list)
{
    for (int index = 0; index < list.Length; index++)
    {
        list[index] *= -1;
    }

    return list;
}
