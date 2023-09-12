// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


using LearnCSharpUtils;


int number = Number.Propmpt("Введите положительное число: ");
int power = Number.Propmpt("Введите степень числа: ");

if (power < 0)
{
    Console.WriteLine("Некорректное указана степень числа.");
    return;
}

int powered = Pow(number, power);
Console.WriteLine($"Число {number}^{power} равно {powered}");



int Pow(int num, int power)
{
    if (power == 0) return 1;

    if (power % 2 == 0) return Pow(num * num, power / 2);
    else return num * Pow(num, power - 1);
}