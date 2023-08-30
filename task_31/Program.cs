// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.


int length = Propmpt("Введите длину массива:");

int[] randomList = GenerateList(length);

PrintList(randomList);

int positive = GetSumPositive(randomList);
int negative = GetSumNegative(randomList);

Console.WriteLine($"Сумма положительных чисел равна {positive}, сумма отрицательных равна {negative}");




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


int GetSumPositive(int[] list)
{
    int result = 0;

    for (int index = 0; index < list.Length; index++)
    {
        if (list[index] > 0)
        {
            result += list[index];
        }
    }

    return result;
}

int GetSumNegative(int[] list)
{
    int result = 0;

    for (int index = 0; index < list.Length; index++)
    {
        if (list[index] < 0)
        {
            result += list[index];
        }
    }

    return result;
}