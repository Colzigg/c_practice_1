// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Массив из какого количества элементов вы хотите создать? ");
int lenM = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lenM];
Console.WriteLine($"Сейчас будем вводить с клавиатуры массив из {lenM} элементов.");
int countZero = 0;

for(int i = 0; i < lenM; i++)
{
    Console.Write($"Введите элемент номер {i+1}: "); 
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) countZero++;
}

Console.WriteLine($"Всего {lenM} элементов в массиве, из них больше нуля - {countZero}");