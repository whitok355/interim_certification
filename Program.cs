// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string [] arr = {"va", "'", "old", "bold", "uppercase", "notebook", "mouse", "table", "book", "food"};
string [] newArr = new string[arr.Length];

string ReduceElement(string el)
{
    string newEl= "";

    for(int i = 0; i < el.Length; i++)
    {
        if(i < 3)
        {
            newEl += el[i];
        } else{
            return newEl;
        }
    }
    return newEl;
}

void FillArr()
{
    for(int i = 0; i < arr.Length; i++)
    {
        newArr[i] = ReduceElement(arr[i]);
    }
}

void Print(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}   ---  {array[i].Length}");
    }
}
FillArr();

Print(arr);
Print(newArr);
