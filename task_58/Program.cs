// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(2, 4);
int colCount = random.Next(2, 4);

int rowCount2 = random.Next(2, 4);
int colCount2 = random.Next(2, 4);

int[,] newMatrix1 = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix1);
Console.WriteLine();

int[,] newMatrix2 = Matrix.GenerateInt(rowCount2, colCount2, 1, 10);
Matrix.PrintInt(newMatrix2);
Console.WriteLine();

if (isValid(newMatrix1, newMatrix2))
{
    int[,] multedMatrix = MultMatrix(newMatrix1, newMatrix2);
    Console.WriteLine($"Результат умножения матриц");
    Matrix.PrintInt(multedMatrix);
}
else
{
    Console.WriteLine($"Умножение матриц невозможно.");
}



int[,] MultMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowCountA = matrixA.GetLength(0);

    int rowCountB = matrixB.GetLength(0);
    int colCountB = matrixB.GetLength(1);

    int[,] multedAB = new int[rowCountA, colCountB];

    for (int col = 0; col < colCountB; col++)
    {
        for (int row = 0; row < rowCountA; row++)
        {
            int sum = 0;
            for (int i = 0; i < rowCountB; i++)
            {
                sum += matrixA[row, i] * matrixB[i, col];
            }

            multedAB[row, col] = sum;
        }
    }

    return multedAB;
}



bool isValid(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}