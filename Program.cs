/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введитете размер масива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] firstArray = new string[size];
for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i + 1}");
    firstArray[i] = Console.ReadLine();
}

string[] secondArray = new string[firstArray.Length];

void NewArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for(int i = 0; i < firstArray.Length; i++)
    {
        if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}

void Printarray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    { 
    Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

NewArray(firstArray, secondArray);
Printarray(secondArray);