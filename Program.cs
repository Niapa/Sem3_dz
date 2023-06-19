/*

Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли
оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
___________________________
1 - int[] InputSomeNums()
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

2 - void PrintArray(int[] array)
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

_________________________________________________________________________________________
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double InputNum (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double Distance (double a1, double b1, double c1, double a2,double b2, double c2)
{
double sum = Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2);
double res = Math.Sqrt(sum);
return res;
}

double num1 = InputNum("Введите координату X точки 1: ");
double num2 = InputNum("Введите координату Y точки 1: ");
double num3 = InputNum("Введите координату Z точки 1: ");
double num4 = InputNum("Введите координату X точки 2: ");
double num5 = InputNum("Введите координату Y точки 2: ");
double num6 = InputNum("Введите координату Z точки 2: ");


double result = Math.Round((Distance(num1, num2, num3, num4, num5, num6)), 1);
Console.WriteLine($"Расстояние между точками 1 и 2 = {result}");
__________________________________________________________________________________________
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int InputNum(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}
int num = InputNum("enter number N: ");
for(int i = 1; i <= num; i++)
{
	Console.Write($"{Math.Pow(i, 3)}");
	if(i < num)
	{
		Console.Write(", ");
	}
	else
	{
		Console.Write(".");
	}
}
