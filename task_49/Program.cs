// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив      Новый массив будет выглядеть
// выглядел вот так:                вот так:
// 2 4 7 2                          4 4 49 2
// 5 9 2 3                          5 9  2 3
// 8 4 2 4                          64 4 4 4


int rowCount = Propmpt("Введите количество строк массива:");
int colCount = Propmpt("Введите количество колонок массива:");

int[,] randomList = GenerateList(rowCount, colCount);
PrintList(randomList);

int[,] powedList = PowEvenElements(randomList);
Console.WriteLine();
PrintList(powedList);



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
            matrix[i, j] = random.Next(-10, 10);
        }
    }

    return matrix;
}

int[,] PowEvenElements(int[,] matrix)
{
    int[,] copy = CopyList(matrix);

    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            copy[i, j] *= copy[i, j];
        }
    }

    return copy;
}

int[,] CopyList(int[,] matrix)
{
    int[,] copy = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < copy.GetLength(0); i++)
    {
        for (int j = 0; j < copy.GetLength(1); j++)
        {
            copy[i, j] = matrix[i, j];
        }
    }

    return copy;
}

void PrintList(int[,] matrix)
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