// task40. Напишите программу, которая  принимает
// на вход три числа и проверяет. может 
// ли существовать треугольник со сторонами
// такой длины. 
//Теорема о неравенстве треугольника:
// каждая сторона труегольника меньше суммы
// двух других сторон.

Console.WriteLine("Введите первую сторону треугольника число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника число:");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(num1, num2, num3);
Console.WriteLine(result? "Треугольник существует" : "Треугольник не существует");

bool IsExistTriangle(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2) return true;
    else return false;
}

