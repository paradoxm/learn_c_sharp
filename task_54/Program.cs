// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System.Linq;
using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 6);
int colCount = random.Next(3, 6);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
Matrix.PrintInt(newMatrix);
Console.WriteLine();

int[,] sortedMatrix = SortMatrixRows(newMatrix);
Matrix.PrintInt(sortedMatrix);



int[,] SortMatrixRows(int[,] matrix)
{
    int[,] copy = Matrix.CopyInt(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = Matrix.GetRowInt(matrix, i);
        row = Sort(row, SortDirection.desc);
        Matrix.SetRowInt(copy, i, row);
    }

    return copy;
}


int[] Sort(int[] list, SortDirection direction)
{
    int[] result = List.CopyInt(list);
    SortLomuto(result, 0, result.Length - 1, direction);

    return result;
}

void SortLomuto(int[] list, int start, int end, SortDirection direction)
{
    if (start > end)
    {
        return;
    }

    int startRightList = PartSortLomuto(list, start, end, direction);
    SortLomuto(list, start, startRightList - 1, direction);
    SortLomuto(list, startRightList + 1, end, direction);
}


int PartSortLomuto(int[] list, int start, int end, SortDirection direction)
{
    int left = start;
    int tmp;

    for (int current = start; current < end; current++)
    {
        if (
            (direction == SortDirection.asc && list[current] <= list[end]) ||
            (direction == SortDirection.desc && list[current] >= list[end])
            )
        {
            tmp = list[current];
            list[current] = list[left];
            list[left] = tmp;
            left++;
        }
    }

    tmp = list[end];
    list[end] = list[left];
    list[left] = tmp;

    return left;
}

enum SortDirection
{
    asc,
    desc,
}