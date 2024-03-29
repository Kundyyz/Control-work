# **Контрольная работа**
## *Выполнение контрольной работы пошагово*
1. Создала репозиторий в *GitHub*
2. Создала локальную папку **"КОНТРОЛЬНАЯ"**
3. Иницировала папку 
>git init
4. Связала удаленный репозиторий с локальным 
```
echo "# Task-0-8" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/Kundyyz/Control-work.git
git push -u origin main
```
5. Создала блок-схему в *diagrams.net*
[Ссылка на мою работу](https://drive.google.com/file/d/18HbkHEvINQYDgXuLjB3Y1GVuIxeLlKu3/view?usp=sharing)
6. Создала папку для алгоритма **"Task"** в папке **"КОНТРОЛЬНАЯ"**
7. Создала шаблон "консольного приложения" 
>dotnet new console
8. В файле **Program.cs** написала алгоритм решения задачи

# *Решение задачи*
1. Просим пользователя задать размер массива:
>Console.WriteLine("Задайте длину массива")
2. Называем переменную **"size"** для длины массива:
>int size = Convert.ToInt32(Console.ReadLine())
3. Пишем первый метод для создания массива.
Через цикл просим пользователя ввести каждый элемент массива.
```
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
```
4. Пишем метод для печати массива в консоль. Для этого используем цикл.
```
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
```
5. Пишем метод для создания нового массива. Длину массива берем рандомную от 1 до 3. Элементы берем из первого массива тоже рандомно. 
```
string[] SecondArray(int min, int max, string[] array)
{
    Random rnd = new Random();
    string[] arr = new string[rnd.Next(min, max + 1)];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[rnd.Next(0, array.Length)];
    }
    return arr;
}
```
6. Задаем аргументы для методов. Даем название переменным. И выводим массивы в консоль:
```
string[] firstArray = FirstArray(size);
PrintArray(firstArray);
Console.Write(" -> ");
string[] secondArray = SecondArray(1, 3, firstArray);
PrintArray(secondArray);
```






