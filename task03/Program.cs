// Task03 Напишите программу, которая будет выдавать
// название дня недели по заданому номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7");
string day1 = Console.ReadLine();

if (day1 == "1") 
{
    Console.WriteLine("Понедельник");
}
else if (day1 == "2") 
{
    Console.WriteLine("Вторник");
}    
else if (day1 == "3")
{
     Console.WriteLine("Среда");
}
else if (day1 == "4") 
{
    Console.WriteLine("Четверг");
}    
else if (day1== "5") 
{
    Console.WriteLine("Пятница");
}
else if (day1 == "6") 
{
    Console.WriteLine("Суббота");
}
else if (day1 == "7") 
{
    Console.WriteLine("Воскресенье");
}    
else 
{
    Console.WriteLine("Error");
}
