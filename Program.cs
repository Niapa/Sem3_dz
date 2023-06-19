/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли
оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
___________________________
1 копипаст: int[] InputSomeNums()
{
    Console.Write("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        else
            Console.Write(".");
    }
}

int[] myArray = InputSomeNums();
PrintArray(myArray);
__________________

2 void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
        else
            Console.Write(".");
    }
}

int num = int.Parse(Console.ReadLine());
int temp = num;

int count = 0;
while (temp != 0)
{
    temp = temp / 10; // num /= 10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--)
{
    array[i] = num % 10;
    num /= 10;
}

PrintArray(array);
_______________________




*/

int[] InputSomeNums()
{
    Console.Write("Введите пятизначное число: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    return array;
}

void PrintArray(int[] array)
{
    if (array[0] == array[4] ^ array[1] == array[3])
        Console.WriteLine("Это палиндром");
    else
        Console.WriteLine("Это не палиндром");
}

int[] oneArray = InputSomeNums();
PrintArray(oneArray);
