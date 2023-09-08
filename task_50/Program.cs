// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


using LearnCSharpUtils;


int userRowIndex = Number.Propmpt("Введите индекс строки:");
int userColIndex = Number.Propmpt("Введите индекс колонки:");

Random random = new Random();
int rowCount = random.Next(2, 5);
int colCount = random.Next(2, 5);

int[,] matrix = Matrix.GenerateInt(rowCount, colCount, 1, 100);
Matrix.PrintInt(matrix);
Console.WriteLine();

if (isValidIndexes(matrix, userRowIndex, userColIndex))
{
    Console.WriteLine($"Элемента с индексами {userRowIndex},{userColIndex} равен {matrix[userRowIndex, userColIndex]}");
}
else
{
    Console.WriteLine($"Элемента с индексами {userRowIndex},{userColIndex} не существует.");
}


bool isValidIndexes(int[,] matrix, int rowIndex, int colIndex)
{
    return rowIndex >= 0 && rowIndex < matrix.GetLength(0) &&
     colIndex >= 0 && colIndex < matrix.GetLength(1);
}