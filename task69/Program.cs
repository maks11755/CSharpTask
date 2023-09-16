// task69. Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second  number");
int number2 = Convert.ToInt32(Console.ReadLine());

 int PowDigitNum(int num1, int num2) 
 {
    if (num2 == 0) return 1; 
    return num1 * PowDigitNum(num1, num2 - 1);
 }

int powDigitNum = PowDigitNum(number1, number2);
Console.WriteLine(powDigitNum);

