// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int rowCount = Propmpt("Введите количество строк массива:");
int colCount = Propmpt("Введите количество колонок массива:");

if (rowCount > 0 && colCount > 0)
{
    double[,] randomMatrix = GenerateMatrix(rowCount, colCount);
    double[,] roundedMatrix = RoundMatrixElements(randomMatrix, 1);
    PrintMatrix(roundedMatrix);
}
else
{
    Console.WriteLine($"Матрица пустая.");
}





int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


double[,] GenerateMatrix(int rowCount, int colCount)
{
    double[,] matrix = new double[rowCount, colCount];
    Random random = new Random();
    double from = -10.0;
    double to = 10.0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * (to - from) + from;
        }

    }

    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

double[,] RoundMatrixElements(double[,] matrix, int presition)
{
    double[,] copy = new double[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < copy.GetLength(0); i++)
    {
        for (int j = 0; j < copy.GetLength(1); j++)
        {
            copy[i, j] = Math.Round(matrix[i, j], presition);
        }
    }

    return copy;
}