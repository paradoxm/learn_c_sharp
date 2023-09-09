// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 5);
int colCount = random.Next(3, 5);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

if (rowCount != colCount)
{
    Console.WriteLine("Не удается поменять местами строки столбцы, т.к. матрица не квадратная");
}
else
{
    ChangeRowsToColumns(newMatrix);
    Matrix.PrintInt(newMatrix);
}


void ChangeRowsToColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}