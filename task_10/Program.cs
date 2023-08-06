Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int positiveNumber = Math.Abs(number);

bool isValid = ValidateNumber(positiveNumber);

if (isValid)
{
    int secondDigit = GetSecondDigit(positiveNumber);

    Console.WriteLine($"Вторая цифра числа: {secondDigit}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}


bool ValidateNumber(int num)
{
    return num >= 100 && num <= 999;
}

int GetSecondDigit(int num)
{
    return num / 10 % 10;
}