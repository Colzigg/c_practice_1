// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] arrayInput()
{
    Console.Write("Массив из какого количества элементов вы хотите создать? ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];
	for(int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(-100, 101);
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

int evenPlaceSumCount(int[] array)
{
    int summ = 0;
	for(int i = 1; i < array.Length; i+=2)
	{
		summ += array[i];
	}
    return summ;
}

int[] array = arrayInput();
arrayOutput(array); // для проверки результата генерации
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {evenPlaceSumCount(array)} ");
