// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using LearnCSharpUtils;

int rowCount = Number.Propmpt("Введите количество строк массива:");
int colCount = Number.Propmpt("Введите количество колонок массива:");

if (rowCount > 0 && colCount > 0)
{
    double[,] randomMatrix = Matrix.GenerateDouble(rowCount, colCount, -10, 10);
    double[,] roundedMatrix = Matrix.RoundElements(randomMatrix, 1);
    Matrix.PrintDouble(roundedMatrix);
}
else
{
    Console.WriteLine($"Матрица пустая.");
}