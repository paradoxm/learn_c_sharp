// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое
// каждого столбца: 4,6; 5,6; 3,6; 3.


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 5);
int colCount = random.Next(3, 5);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

double[] avgSum = AvgColumnSum(newMatrix);

Console.Write($"Среднее арифметическое элементов в каждом столбце равно ");
List.PrintDouble(avgSum);


double[] AvgColumnSum(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    double[] avarageSum = new double[colCount];

    for (int col = 0; col < colCount; col++)
    {
        for (int row = 0; row < rowCount; row++)
        {
            avarageSum[col] += matrix[row, col];
        }

        avarageSum[col] /= rowCount;
    }

    return avarageSum;
}