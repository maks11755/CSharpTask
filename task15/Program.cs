// task15: Напишите программу, которая принимает
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
string day1 = Console.ReadLine();

if (day1 == "1") 
{
    Console.WriteLine("Понедельник. Не выходной день.");
}
else if (day1 == "2") 
{
    Console.WriteLine("Вторник. Не выходной день.");
}    
else if (day1 == "3")
{
    Console.WriteLine("Среда. Не выходной день.");
}
else if (day1 == "4") 
{
    Console.WriteLine("Четверг. Не выходной день.");
}    
else if (day1 == "5") 
{
    Console.WriteLine("Пятница. Не выходной день.");
}
else if (day1 == "6") 
{
    Console.WriteLine("Суббота. Выходной day");
}
else if (day1 == "7") 
{
    Console.WriteLine("Воскресенье. Выходной day");
}    
else 
{
    Console.WriteLine("Error");
}
