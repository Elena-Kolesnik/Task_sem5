// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();

double[] numbers = new double[5];
double min = Int32.MaxValue;
double max = Int32.MinValue;

WriteLine("Массив: ");

void FillRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
        }
}
FillRandomNumbers(numbers);

void PrintArray(double[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Write(numbers[i] + "  ");
        }
   Write("]");
   WriteLine();
}
PrintArray(numbers);
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

