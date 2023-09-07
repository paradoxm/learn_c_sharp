// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон


int triangleSide1 = Propmpt("Введите первую сторону треугольника: ");
int triangleSide2 = Propmpt("Введите первую вторую треугольника: ");
int triangleSide3 = Propmpt("Введите первую трутью треугольника: ");

bool valid = ValidTriangle(triangleSide1, triangleSide2, triangleSide3);
string exists = valid ? "существует" : "не существует";

Console.WriteLine($"Треугольник со тсоронами {triangleSide1},{triangleSide2},{triangleSide3} {exists}");



int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


bool ValidTriangle(int side1, int side2, int side3)
{
    return side1 < side2 + side3 &&
    side2 < side1 + side3 &&
    side3 < side1 + side2;
}
