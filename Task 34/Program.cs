// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random(). Next (100, 1000);
    }
}

void PrintArray (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void FindCount (int[] array)
{
    int sum=0;
    foreach (var item in array)
         if (item%2==0)
            sum++;
    System.Console.WriteLine($"Количество четных чисел равно {sum}");       
}

System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
FindCount(array);

