// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


string result = IsSquare(number1, number2) ? "Да" : "Нет";
Console.WriteLine(result);



bool IsSquare(int num1, int num2)
{
    int square1 = num1 * num1;
    int square2 = num2 * num2;

    return num1 == square2 || num2 == square1 ;
}