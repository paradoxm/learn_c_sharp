// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Некорректно введенное число");
}
else
{
    int result = Mult(number);
    Console.WriteLine($"Произведение чисел от 1 до {number}: {result}");
}




int Mult(int to)
{
    int result = to == 0 ? 0 : 1;

    for (int i = 1; i <= to; i++)
    {
        checked
        {
            result *= i;
        }
    }

    return result;
}