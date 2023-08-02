Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Ошибка! Введено некорректное число");
}
else if (number < 2)
{
    Console.WriteLine("Чётные числа отсутствуют");
}
else if (number >= 0)
{
    Console.WriteLine($"Чётные числа от 1 до {number}");

    for (int i = 1; i <= number; i++)
    {
        bool isEven = i % 2 == 0;

        if (isEven)
        {
            Console.Write($"{i} ");
        }

    }
    Console.WriteLine("");
}



