// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int result = Sum(1, number);
Console.WriteLine($"Сумма чисел от 1 до {number}: {result}");



int Sum(int from, int to)
{
    int sum = 0;

    for (int i = from; i <= to; i++)
    {
        checked
        {
            sum += i;
        }
    }

    return sum;
}