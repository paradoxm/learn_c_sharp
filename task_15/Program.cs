Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isValid = ValidateNumber(number);

if (isValid)
{
    bool isWeekend = NumberIsWeekend(number);
    string result = isWeekend ? "да" : "нет";

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный номер дня недели");
}


bool ValidateNumber(int num)
{
    return num >= 1 && num <= 7;
}

bool NumberIsWeekend(int num)
{
    return num == 6 || num == 7;
}