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
