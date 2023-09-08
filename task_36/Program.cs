// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using LearnCSharpUtils;

int length = Number.Propmpt("Введите длину массива:");

int[] randomList = List.GenerateInt(length, 1, 100);
List.Print(randomList);

int sumOddPosition = SumOddPosition(randomList);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumOddPosition}");


int SumOddPosition(int[] list)
{
    int sum = 0;

    for (int index = 1; index < list.Length; index += 2)
    {
        sum += list[index];
    }

    return sum;
}
