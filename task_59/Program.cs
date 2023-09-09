// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 6);
int colCount = random.Next(3, 6);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

int[] minElementIndexes = GetIndexesWithMinElement(newMatrix);
int rowIndex = minElementIndexes[0];
int colIndex = minElementIndexes[1];
int minValue = newMatrix[rowIndex, colIndex];

Console.WriteLine($"Наименьший элемент [{rowIndex},{colIndex}] - {minValue}");
Console.WriteLine();

int[,] smallMatrix = RemoveRowAndCol(newMatrix, rowIndex, colIndex);
Matrix.PrintInt(smallMatrix);



int[] GetIndexesWithMinElement(int[,] matrix)
{
    int minRowIndex = 0;
    int minColIndex = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minRowIndex, minColIndex] > matrix[i, j])
            {
                minRowIndex = i;
                minColIndex = j;
            }
        }
    }

    return new int[] { minRowIndex, minColIndex };
}


int[,] RemoveRowAndCol(int[,] matrix, int removeRowIndex, int removeColIndex)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == removeRowIndex) continue;

        int newRowIndex = i > removeRowIndex ? i - 1 : i;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == removeColIndex) continue;

            int newColIndex = j > removeColIndex ? j - 1 : j;

            newMatrix[newRowIndex, newColIndex] = matrix[i, j];
        }
    }

    return newMatrix;
}