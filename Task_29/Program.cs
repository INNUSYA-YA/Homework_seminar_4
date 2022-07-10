//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] numbers = new int[8];
for (int index = 0; index < numbers.Length; index++)
{
    numbers[index] = new Random().Next(1,100);
}
PrintArray(numbers);


void PrintArray(int[] array)
{
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i]+ " ");
}
Console.WriteLine();
}