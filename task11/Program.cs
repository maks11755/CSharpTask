﻿// task11. Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100-999 -> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine(result);

int twoNumbers = TwoNumbers(number);
Console.WriteLine(twoNumbers);

int TwoNumbers(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int result = firstDigit * 10 + lastDigit;
    return result;
}
