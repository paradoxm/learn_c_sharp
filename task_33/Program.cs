// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int length = Propmpt("Введите длину массива:");
int number = Propmpt("Введите число:");

int[] randomList = GenerateList(length);
PrintList(randomList);

int numberIndex = IndexOf(randomList, number);

if (numberIndex >= 0)
{
    Console.WriteLine($"Число встречается в массиве на {numberIndex} позиции");
}
else
{
    Console.WriteLine("Числа в массиве нет");
}





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


int IndexOf(int[] list, int number)
{

    for (int index = 0; index < list.Length; index++)
    {
        if (list[index] == number)
        {
            return index;
        }
    }

    return -1;
}
