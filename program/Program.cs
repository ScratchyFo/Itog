// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. *
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void getArray(string[] rawArray, string[] limitArray)
{
    int count = 0;
    for (int i = 0; i < rawArray.Length; i++)
    
    {
    if(rawArray[i].Length <= 3)
        {
            limitArray[count] = rawArray[i];
            count++;
        }
    }
}

void printArray(string[] limitArray)
{
    for (int i = 0; i < limitArray.Length; i++)
    {
        Console.Write($"{limitArray[i]} ");
    }
}

Console.Clear();

Console.Write("Введите массив через пробел: ");
string[] rawArray = Array.ConvertAll(Console.ReadLine()!.Split(' '), Convert.ToString)!;

string[] limitArray = new string[rawArray.Length];

getArray(rawArray, limitArray);

printArray(limitArray);