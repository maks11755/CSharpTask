// task65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.WriteLine("Enter first number");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int count = number1;
// while (count <= number)
// {
//     Console.Write($"{count} ");
//     count++;
// }

Console.WriteLine("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 1 & number2 < 1)
{
    Console.WriteLine("Input error");
    return;
}

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    else Console.Write($"{num1}");
}

NaturalNumbers(number1, number2);