// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray (double[] array)
{
    Random random = new Random();
    for (int i=0; i<array.Length; i++)
    {
        array[i] = random.NextDouble()*100;
    }
}

void PrintArray (double[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void Difference (double[] array)
{
    double min = array[0];
    double max = array[0];
        for (int i = 1; i < array.Length; i ++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
    double difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);    
}

       


System.Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
Difference(array);