Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine($"Числа равны");
}
else
{
    double min = number1 < number2 ? number1 : number2;
    double max = number1 > number2 ? number1 : number2;
    Console.WriteLine($"Число {max} больше числа {min}");
}