Console.Write("Введите целое положительное число: ");
uint number = Convert.ToUInt32(Console.ReadLine());

int fromRange = Convert.ToInt32(-number);


for (int i = fromRange; i < number; i++)
{
    Console.Write($"{i} ");
}
Console.WriteLine("");
