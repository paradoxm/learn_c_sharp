Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int positiveNumber = Math.Abs(number);

bool isValid = ValidateNumber(positiveNumber);

if (isValid)
{
    int thirdDigit = GetThirdDigit(positiveNumber);

    Console.WriteLine($"Вторая цифра числа: {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


bool ValidateNumber(int num)
{
    return num >= 100;
}

int GetThirdDigit(int num)
{
    int bufNumber = num;

    while (bufNumber > 999)
    {
        bufNumber /= 10;
    }

    return bufNumber % 10;
}