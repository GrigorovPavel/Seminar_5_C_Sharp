﻿// Задача31. Напишите программу, которая
// 1. задает массив из 12 элементов  
// 2. заполненный случайными числами из промежутка [-9, 9]
// 3. Найдите сумму отрицательных и положительных элементов Массива.
//
// Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных чисел равна -20

int[] CreateArrayRndInt(int size, int max, int min) // Создаем Метод для Массива с переменными size, max, min 
{
    int[] arr = new int[size]; // Создаем Массив в количеством элементов size
    Random rnd = new Random(); // Создаем объект под который выделяется память для случайных чисел в Массиве  

    for (int i = 0; i < size; i++) // Условие цикла i < size (размера массива)
    {
        arr[i] = rnd.Next(min, max + 1); // Берем элемент Массива по индексу [i] и Заполняем случайными числами с помощю Метода Next()
        // +1 это корректировка, чтобы при использовании функции, мы задовали требуемый нам диапозон
        // Если убрать +1 то диапозон будет от -9 до 8, а необходимо от -9 до 9. Либо указывать диапозон (-9, 10).
    }
    return arr; // Возвращаем созданный массив
}

void PriintArray(int[] arr)
{
    Console.Write("["); // Перед началом Цикла выводим квадратную скобку -> для вывода как в условии
    for (int i = 0; i < arr.Length; i++) // Условие цикла i < arr.Length (свойства массива)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, "); // Если индекс элемента меньше длинны Массива
        // i< arr.Length -1, то выводим {arr[i]}, - (значение с запятой). Либо через дополнительный параметр
        // в Методе PrintArray можем выводить любые символы - Например (char simb = !) и вызвать {simb}
        else Console.Write($"{arr[i]}"); // Выводим элементы Массива без запятой - {arr[i]}
    }
    Console.WriteLine("]"); // После окончания Цикла выводим квадратную скобку -> для вывода как в условии
}

// Создадим Метод который будет определять сумму отрицательных и положительных 
// элементов Массива через Массив с двумя значениями
int[] GetSumPositivNegativElem(int[] arr) // Создаем Метод и передаем в него (объект)-Массив 
{
    int sumPositiv = 0; // Инициируем переменную для суммы положительных чисел
    int sumNegativ = 0; // Инициируем переменную для суммы отрицательных чисел
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) // Если элемент Массива arr[i] < 0
        {
            sumPositiv = sumPositiv + arr[i]; // то делай ээто (прибавляй элемент arr[i] к sumPositiv)
        }
        else sumNegativ = sumNegativ + arr[i]; // иначе делай это (прибавляй элемент arr[i] к sumNegativ)
    }
    return new int[] { sumPositiv, sumNegativ }; // СОЗДАЕМ и Возвращаем Массив. Без указание длинны. 
    // Элементы (значения) в фигурных скобках.
}

// Создадим ДВА Метода которые будет определять сумму отрицательных и положительных 
// элементов Массива через переменные
int GetSumPositivElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum = sum + arr[i];
    }
    return sum;
}

int GetSumNegativElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum = sum + arr[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(12, 9, -9); // Вызываем Метод для int[] array
PriintArray(array); // Выводим в Консоль
// Console.Write(" -> [");
// PriintArray(array);
// Console.WriteLine("]"); // Для вывода как в домашней задаче!

int[] getSumPositivNegativElem = GetSumPositivNegativElem(array); // Присваиваем Массиву результат Метода
Console.WriteLine($"Сумма положительных элементов массива => {getSumPositivNegativElem[0]}"); 
// Выводим в консоль нулевой элемент массива getSumPositivNegativElem[0] - сумма положительных чисел
Console.WriteLine($"Сумма отрицательных элементов массива => {getSumPositivNegativElem[1]}"); 
// Выводим в консоль первый элемент массива getSumPositivNegativElem[1] - сумма отрицательных чисел

int sumPositivElem = GetSumPositivElem(array);
int getSumNegativElem = GetSumNegativElem(array);
Console.WriteLine($"Сумма положительных элементов массива =>{sumPositivElem} !");
Console.WriteLine($"Сумма отрицательных элементов массива =>{getSumNegativElem} !");