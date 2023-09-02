// task 24. Создайте программу, которая на 
// вход принимает число (А) и выдает
// сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        sum += i; // sum = sum + i;
        }
    }
    return sum;
}
// added checked

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумму чисел от 1 до {number} = {result}");