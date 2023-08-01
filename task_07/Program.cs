Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}

bool isValid = number >= 100 && number <= 999;


if (isValid)
{
    int lastNum = number % 10;
    Console.WriteLine($"Последняя цифра: {lastNum}");
}
else
{
    Console.WriteLine("Ввели некорректное число");
}
