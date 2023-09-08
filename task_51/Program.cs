// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int rowCount = Propmpt("Введите количество строк массива:");
int colCount = Propmpt("Введите количество колонок массива:");

int[,] randomList = GenerateList(rowCount, colCount);
PrintMatrix(randomList);
Console.WriteLine();

int[] mainElements = SumMainDiagonal(randomList);
int sumElements = SumList(mainElements);

string sumElementsStr = string.Join(" + ", mainElements);
Console.WriteLine($"Сумма элементов главной диагонали {sumElementsStr} = {sumElements}");



int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


int[,] GenerateList(int rowCount, int colCount)
{
    int[,] matrix = new int[rowCount, colCount];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }

    return matrix;
}


int[] SumMainDiagonal(int[,] matrix)
{
    int minLength = matrix.GetLength(0) > matrix.GetLength(1) ? matrix.GetLength(1) : matrix.GetLength(0);
    int[] elements = new int[minLength];

    for (int i = 0; i < minLength; i++)
    {
        elements[i] = matrix[i, i];
    }

    return elements;
}


int SumList(int[] list)
{
    int sum = 0;
    for (int i = 0; i < list.Length; i++)
    {
        sum += list[i];
    }

    return sum;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}