// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

void ArrayRandom(int[] num)
{
    for(int j = 0; j < num.Length; j++)
        {
            num[j] = new Random().Next(1,10);
        }
}

void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int j = 0; j < num.Length; j++)
        {
            Console.Write(num[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


int[] num = new int[size];
ArrayRandom(num);

Console.WriteLine("Вот наш массив: ");
PrintArray(num);

int sum = 0;
for (int i = 0; i < num.Length; i+=2)
    sum = sum + num[i];

    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");


