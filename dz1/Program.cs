// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random myRandom = new Random();
 
Console.WriteLine("Наш массив: ");
for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(100, 999);
        Console.Write("{0} ", array[i]);
    }

int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine();
Console.WriteLine($"Из них четных чисел: {count}");