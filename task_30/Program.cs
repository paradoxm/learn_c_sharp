// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] binArray = new int[8];

FillBinArray(binArray);

WriteBinArray(binArray);



void FillBinArray(int[] array)
{
    Random random = new Random();

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = random.Next(2);
    }

}

void WriteBinArray(int[] array)
{
    string result = string.Join(',', array);

    Console.WriteLine($"[{result}]");
}