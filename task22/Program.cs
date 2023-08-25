//task22. Напишите программу, которая
// принимает на вход число (N) и выдает таблицу
// квадратов чисел

void TableSquare(int num)
{
    int count = 1;
    while(count <= num)
    {
       Console.WriteLine($"{count, 3} -> {count*count, 5}");
       count++;
    }
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);
