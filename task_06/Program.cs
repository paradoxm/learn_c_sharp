Console.Write("Введите число, чтобы проверить является ли оно четным: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}