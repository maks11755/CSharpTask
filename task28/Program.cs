// task28. Напишите программу, которая 
// на вход принимает N и выдает произведение
// от 1 до N.
// 4 -> 24
// 5 -> 120

int Multiplaynumber(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        mult *= i; // sum = sum * i;
        }
    }
    return mult;
}
// added checked

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = Multiplaynumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");
