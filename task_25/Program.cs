// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Некорректно введенное число B");
}
else
{
   double powered = Pow(numberA, numberB);
   Console.WriteLine($"Число A в натуральной степени B: {powered}");
}



double Pow(int num, int power)
{
    double result = 1;

    for (int i = 1; i <= power; i++)
    {
        checked
        {
            result *= num;
        }
    }

    return result;
}