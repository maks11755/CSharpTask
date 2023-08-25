// task16 Напишите программу, которая принимает
// на вход два числа и проверяет. является 
// ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет
// if (number1/number2 == number2 r|| number2/number1 == number1 )
// {

//  Console.WriteLine("Да");

//  }

//  else

//  {

//  Console.WriteLine("Нет");

//  }

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = MultTwoNum(num1, num2);
Console.WriteLine(result ? "Да" : "Нет");

bool MultTwoNum(int numb1, int numb2)
{
    return numb1 / numb2 == numb2 || numb2 / numb1 == numb1;
}
