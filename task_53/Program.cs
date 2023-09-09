// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 5);
int colCount = random.Next(3, 5);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

int firstIndex = 0;
int lastIndex = newMatrix.GetLength(0) - 1;
int[,] changedMatrix = ChangeRowPosition(newMatrix, firstIndex, lastIndex);
Matrix.PrintInt(changedMatrix);


int[,] ChangeRowPosition(int[,] matrix, int sourceIndex, int targetIndex)
{
    int[,] copy = Matrix.CopyInt(matrix);

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        copy[sourceIndex, i] = matrix[targetIndex, i];
        copy[targetIndex, i] = matrix[sourceIndex, i];
    }

    return copy;
}