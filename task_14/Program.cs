// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = MultiplicityTwoNumbers(number, 7, 23) ? "Да" : "Нет";
Console.WriteLine(result);



bool MultiplicityTwoNumbers(int num, int fist, int second)
{
    int rest7 = num % fist;
    int rest23 = num % second;

    return rest7 == 0 && rest23 == 0;
}