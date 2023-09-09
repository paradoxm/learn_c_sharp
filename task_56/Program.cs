// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 6);
int colCount = random.Next(3, 6);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

int[] rowsSum = RowsSum(newMatrix);
Console.Write("Суммы строк ");
List.PrintInt(rowsSum);

int minRowIndex = MinIndex(rowsSum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRowIndex + 1} строка");




int[] RowsSum(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int[] sum = new int[rowCount];

    for (int row = 0; row < rowCount; row++)
    {
        for (int col = 0; col < colCount; col++)
        {
            sum[row] += matrix[row, col];
        }
    }

    return sum;
}

int MinIndex(int[] list)
{
    int minIndex = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[minIndex] > list[i])
        {
            minIndex = i;
        }
    }

    return minIndex;
}