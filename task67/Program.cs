// task67. Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12, 45 -> 9

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialRec(2));
 
 
 int SumDigitNum(int num) // 453 ----45 ---4 --0
 {
    if (num == 0) return 0; // <-  в return меняем 0 на любую цифрую Эта цифра 
    // будет прибовляться к результату введенного числа
    return num % 10 +  SumDigitNum(num / 10); //  в стек сохраняется 453, 45, 4
    // 4% 10 + 45% 10+ 453% 10 = 4 + 5 + 3 = 12  и + 0 который вернул  return.
 }

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigitNum(number));


