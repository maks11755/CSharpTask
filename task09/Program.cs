// task09. Напишите программу, которая
// 1. Выводит случайное число из отрезка [10, 99] и
// 2. Показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 99 + 1
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7.8 = 7
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int MaxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num  % 10;
   // if (firstDigit > secondDigit) return firstDigit;
   // return secondDigit;
   int MaxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
   return secondDigit;
}
