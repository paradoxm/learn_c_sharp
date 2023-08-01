Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number1 * number1;
bool result = square == number2;


if(result) {
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
} else {
    Console.WriteLine($"Число {number1} не является квадратом числа {number2}");
}
