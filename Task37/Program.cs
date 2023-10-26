// Задача 37.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишем в новом массиве
// [1,2,3,4,5] -> 5 ,8, 3
// [6,7,3,6] -> 36, 21

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
    //Console.Write("["); 
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); 
        else Console.Write($"{arr[i]}"); 
    }
    //Console.WriteLine("]");
}

int[] ProductOfNumbers(int[] arr)
{   // Получаем размер для нового Массива
    int size = arr.Length / 2;
    if(arr.Length %2 != 0) size +=1;
    // Создаем новый Массив
    int[] arrNew = new int[size];
    // Заполняем новый Массив произведением пар чисел
    for (int i = 0; i < arr.Length / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    // Для массива с НЕЧЕТНЫМ размером, добавляем в последний элемент значение среднего элемента исходного Массива
    if(arr.Length %2 != 0) arrNew[arrNew.Length -1] = arr[arr.Length / 2];
    return arrNew;
}

int[] array = CreateArrayRndInt(5, 9, 1); 
Console.Write("["); 
PriintArray(array);
Console.WriteLine("]");

int[] productOfNumbers = ProductOfNumbers(array);
Console.Write("["); 
PriintArray(productOfNumbers);
Console.WriteLine("]");