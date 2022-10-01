// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] arrayInputDouble()
{
    Console.Write("Массив из какого количества элементов вы хотите создать? ");
    int count = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[count];
	for(int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(-100, 101); //rand.NextDouble() я не стал использовать, можно было прибавить его просто, но в любом случае по типу массив double
	}
    return array;
}

void arrayOutput(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double diffMinMaxCount(double[] array) // можно это было разбить на два метода (поиск мин, поиск макс) и одно действие (разница) 
{
    double minElem = array[0];
    double maxElem = array[0];
    for(int i = 1; i < array.Length; i++)
	{
		if(array[i] < minElem)
        {
            minElem = array[i];
        }
        else if(array[i] > maxElem)
        {
            maxElem = array[i];
        }
	}
    Console.WriteLine($"Максимальный элемент массива равен {maxElem} ");
    Console.WriteLine($"Минимальный элемент массива равен {minElem} ");
    double diff = maxElem - minElem;
    return diff;
}

double[] array = arrayInputDouble();
arrayOutput(array); // для проверки результата генерации
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {diffMinMaxCount(array)} ");