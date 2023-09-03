// task39. Напишите программу, которая перевернет
// одномерный массив (последний элемент будет на 
// первом месте, а первый - на последнем и т.д.).
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1], [6, 7, 3, 6] -> [6, 3, 7, 6].

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    } 
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++) // 1
    {
        int temp = arr[i]; // temp = arr[1] = 2
        arr[i] = arr[arr.Length - 1 - i]; // arr[0] = 5
        arr[arr.Length - 1 - i] = temp; //  arr[arr.Length - 1 - i] = 2
    }
}

int[] array = CreateArrayRndInt(5, 0, 5);
PrintArray(array);
Console.WriteLine();

ReverseArray(array);
PrintArray(array);
Console.WriteLine();

// Array.Reverse(array);
// PrintArray(array);


