Console.WriteLine("Задайте длину массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FirstArray(size);
PrintArray(firstArray);
Console.Write(" -> ");
string[] secondArray = SecondArray(1, 3, firstArray);
PrintArray(secondArray);

string[] FirstArray(int lenghtArray)
{
    string[] array = new string[lenghtArray];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

