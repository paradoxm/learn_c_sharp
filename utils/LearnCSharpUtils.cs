namespace LearnCSharpUtils
{
    public static class Number
    {
        static void Main() { }

        public static int Propmpt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt32(input);
        }
    }

    public static class Double
    {
        public static double Propmpt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToDouble(input);
        }
    }

    public static class List
    {
        public static void PrintInt(int[] list, string delimeter = ",")
        {
            string joinedList = string.Join(delimeter, list);
            Console.WriteLine($"[{joinedList}]");
        }

        public static void PrintDouble(double[] list)
        {
            string joinedList = string.Join(", ", list);
            Console.WriteLine($"[{joinedList}]");
        }

        public static int[] GenerateInt(int count, int from, int to)
        {
            int[] list = new int[count];
            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                list[index] = random.Next(from, to + 1);
            }

            return list;
        }

        public static double[] GenerateDouble(uint count, double from, double to)
        {
            double[] list = new double[count];
            Random random = new Random();

            for (int index = 0; index < count; index++)
            {
                list[index] = random.NextDouble() * (to - from) + from;
            }

            return list;
        }

        public static double[] RoundElements(double[] list, int presition)
        {
            double[] roundedList = new double[list.Length];

            for (int index = 0; index < roundedList.Length; index++)
            {
                roundedList[index] = Math.Round(list[index], presition);
            }

            return roundedList;
        }

        public static double MaxDouble(double[] list)
        {
            double maxNumber = list[0];

            for (int i = 0; i < list.Length; i++)
            {
                if (maxNumber < list[i])
                {
                    maxNumber = list[i];
                }

            }

            return maxNumber;
        }

        public static double MinDouble(double[] list)
        {
            double minNumber = list[0];

            for (int i = 0; i < list.Length; i++)
            {
                if (minNumber > list[i])
                {
                    minNumber = list[i];
                }

            }

            return minNumber;
        }
    }

    public static class Matrix
    {
        public static int[,] GenerateInt(int rowCount, int colCount, int from, int to)
        {
            int[,] matrix = new int[rowCount, colCount];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(from, to + 1);
                }

            }

            return matrix;
        }

        public static double[,] GenerateDouble(int rowCount, int colCount, double from, double to)
        {
            double[,] matrix = new double[rowCount, colCount];
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.NextDouble() * (to - from) + from;
                }

            }

            return matrix;
        }

        public static void PrintInt(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintDouble(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6}");
                }
                Console.WriteLine();
            }
        }

        public static double[,] RoundElements(double[,] matrix, int presition)
        {
            double[,] copy = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < copy.GetLength(0); i++)
            {
                for (int j = 0; j < copy.GetLength(1); j++)
                {
                    copy[i, j] = Math.Round(matrix[i, j], presition);
                }
            }

            return copy;
        }

        public static int[,] CopyInt(int[,] matrix)
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

        public static int[] ToListInt(int[,] matrix)
        {
            int[] list = new int[matrix.GetLength(0) * matrix.GetLength(1)];
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    list[count++] = matrix[i, j];
                }
            }

            return list;
        }
    }

}
