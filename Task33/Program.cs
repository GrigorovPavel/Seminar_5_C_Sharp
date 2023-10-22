// Задача 33.
// Задайте Массив.
// Напишите программу, которая
// определяет, присутствует ли заданное число в Массиве
// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да


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
    Console.Write("]"); 
}

bool FindNumber(int[] arr, int num) // Метод определяет, присутствует ли заданное число в Массиве
// Передаем в Метод Массив и ЧИСЛО которое будем искать
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите значение элемента массива:");
int findeNumber = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(12, 9, -9); 
PriintArray(array); 
bool findNumber = FindNumber(array, findeNumber);
if(findNumber == true)
{
    Console.WriteLine($"-> да");
}
else Console.WriteLine($"-> нет");





