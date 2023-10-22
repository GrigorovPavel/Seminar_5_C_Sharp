// Задача 35.
// Задать одномерный массив из 123 случайных чисел
// Найти количество элементов массива, в диапозоне [10, 99]
//

int[] CreateArrayRndInt(int size, int max, int min) // Создаем Метод для Массива с переменными size, max, min 
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 

    for (int i = 0; i < size; i++) 
    {
        arr[i] = rnd.Next(min, max + 1); 
    }
    return arr; 
}

void PriintArray(int[] arr)
{
    Console.Write("["); 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    Console.WriteLine("]");
}

int TwoDigitNumbers(int[] arr, int min, int max) // Метод проверяет находится ли элемент массива (int[] arr), в диапозоне [min, max]
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArrayRndInt(10, 123, -123); 
int twoDigitNumbers = TwoDigitNumbers(array, 10, 99);

PriintArray(array);
Console.WriteLine($"Число элементов в диапозоне [10, 99] -> {twoDigitNumbers}");