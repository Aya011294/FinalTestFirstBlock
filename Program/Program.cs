/*  Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */




Enter();
string[] Array = new string[] {};

string enter = ReadInput("Введите команду: ");
switch (enter)
{
    case "1":
        Array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        Array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        Array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{enter} - Такой команды нет");
        break;
}


int lenArray = 0;
for (int i = 0; i <= Array.Length - 1; i++)
{
    if (Array[i].Length <= 3) lenArray++;
}

string[] newArray = new string[lenArray];
int index = 0;

for (int i = 0; i <= Array.Length - 1; i++)
{
    if (Array[i].Length <= 3)
    {
        newArray[index] = Array[i];
        index++;
    }
}

PrintArray(Array);
Console.Write("→ ");
PrintArray(newArray);

void Enter()
{
    Console.WriteLine();
    Console.WriteLine("СПИСОК КОМАНД:");
    Console.WriteLine("1 – использовать массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – использовать массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}


string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
