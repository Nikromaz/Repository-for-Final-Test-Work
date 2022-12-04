// Задача: Написать программу, которая из имеющегося массива
// строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FindingSmallValues(string[] array, int num)
{
    string newStringResult = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < num) newStringResult = newStringResult + array[i] + " ";
    }
    string[] newArray = newStringResult.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}
Console.Clear();
Console.Write("Введите элементы строки через пробел: ");
string input = (Console.ReadLine()!);
int num = 4;
string[] array = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.Write($"Значения строки массива меньше четырех символов: {string.Join(", ", FindingSmallValues(array, num))}.");