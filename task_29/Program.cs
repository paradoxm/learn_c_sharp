// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Необходимо ввести массив из 8 чисел");
int[] userList = ReadNumbers(8);

PrintArray(userList);



int[] ReadNumbers(uint count)
{
    int[] list = new int[count];

    for (int index = 0; index < count; index++)
    {
        Console.Write($"Введите {index + 1}: ");

        var number = Convert.ToInt32(Console.ReadLine());
        list[index] = number;
    }

    return list;
}


void PrintArray(int[] list)
{
    string joinedList = string.Join(",", list);

    Console.WriteLine($"[{joinedList}]");
}