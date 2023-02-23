Console.WriteLine("Задайте длину массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FirstArray(size);
PrintArray(firstArray);
Console.Write(" -> ");
string[] secondArray = SecondArray(1, 3, firstArray);
PrintArray(secondArray);

