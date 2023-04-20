// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] arr = {"va", "'", "old", "bold", "uppercase", "notebook", "mouse", "table", "book", "food"};
int index = 0;

void Sort()
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            index++;
        }
    }
    string [] newArr = new string[index];
    index = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    Print(newArr);
}

void Print(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}   ---  {array[i].Length}");
    }
}

Sort();