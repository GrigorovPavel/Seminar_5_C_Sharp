// Задача 32
// Напишите программу замены элементов массива:
// положительные элементы заменить на отрицательные и наоборот
// [-4,-8,8,2] -> [4,8,-8,-2]
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
    }
    Console.WriteLine("]"); 
}

void InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] *= -1;
    }
}

int[] array = CreateArrayRndInt(12, 9, -9); 
PriintArray(array); 

InversArray(array);
PriintArray(array); 

