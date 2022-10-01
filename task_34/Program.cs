// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] arrayInput()
{
    Console.Write("Массив из какого количества элементов вы хотите создать? ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];
	for(int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(100, 1000);
	}
    return array;
}

void arrayOutput(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int evenCount(int[] array)
{
    int count = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if((array[i] % 2) == 0)
        {
            count++;
        }
	}
    return count;
}

int[] array = arrayInput();
arrayOutput(array); // для проверки результата генерации
Console.WriteLine($"Количество положительный числе в сгенерированном массиве - {evenCount(array)} ");