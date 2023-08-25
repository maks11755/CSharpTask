// task17. Напишите программу, которая
// принимает на вход координаты точки (x i y),
// причем x ≠ 0, y ≠ 0 и выдает номер четверти 
// плоскости, в которой находится эта точка.

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result =  quarter > 0 ? " указанные координаты соответствуют четверти -> {quarter}"
                             : " Введены некоректные координаты";
Console.WriteLine(result);    
