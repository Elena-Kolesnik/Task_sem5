// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

WriteLine("Массив: ");
int[] array = new int[4];
int sumNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    Write(array[i] + " ");
}
for (int j = 1; j < array.Length; j = j + 2)
{
    sumNumbers += array[j];
}
WriteLine();
WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumNumbers}");
