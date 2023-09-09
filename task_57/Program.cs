// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }       0 встречается 2 раза
//                                  1 встречается 1 раз
//                                  2 встречается 1 раз
//                                  8 встречается 1 раз
//                                  9 встречается 3 раза

// 1, 2, 3                          1 встречается 3 раза
// 4, 6, 1                          2 встречается 2 раз
// 2, 1, 6                          3 встречается 1 раз
//                                  4 встречается 1 раз
//                                  6 встречается 2 раза


using LearnCSharpUtils;


Random random = new Random();
int rowCount = random.Next(3, 5);
int colCount = random.Next(3, 5);

int[,] newMatrix = Matrix.GenerateInt(rowCount, colCount, 1, 10);
int[] newList = Matrix.ToListInt(newMatrix);
Array.Sort(newList);
Matrix.PrintInt(newMatrix);
Console.WriteLine();
List.PrintInt(newList);

PrintFrequencyDict(newList);



void PrintFrequencyDict(int[] list)
{
    if (list.Length == 0)
    {
        Console.WriteLine("Нет данных для определения частотности.");
        return;
    }

    int count = 1;
    int prevValue = list[0];
    for (int i = 1; i < list.Length; i++)
    {
        if (prevValue == list[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{prevValue} встречается {count} раз(а)");
            count = 1;
            prevValue = list[i];
        }
    }

    Console.WriteLine($"{prevValue} встречается {count} раз(а)");
}

