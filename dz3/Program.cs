// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

void ArrayRandom(double[] num)
{
    for(int j = 0; j < num.Length; j++)
        {
            num[j] = new Random().Next(1,10);
        }
}

void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int j = 0; j < num.Length; j++)
        {
            Console.Write(num[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


double[] num = new double[size];
ArrayRandom(num);

Console.WriteLine("Вот наш массив: ");
PrintArray(num);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < num.Length; z++)
{
    if (num[z] > max)
        {
            max = num[z];
        }
    if (num[z] < min)
        {
            min = num[z];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");