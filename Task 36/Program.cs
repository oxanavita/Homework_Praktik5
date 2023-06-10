// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random(). Next (-10, 100);
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

void FindIndexN (int[] array)
{
    int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        Console.WriteLine("\nСумма элементов на нечетных индексах: " + sum);
}


System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
FindIndexN(array);
