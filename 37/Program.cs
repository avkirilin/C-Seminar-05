//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний, и т.д. Результат запишите в новом массиве.
// [1, 2, 3, 4, 5] --> [5, 8, 3]; [6, 7, 3, 6] --> [36, 21];
Console.Clear();
int[] GetRandomArray(int size)                                  //метод получения массива заданной длины, заполняемый случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}
void PrintArray(int[] printingArray)                            //метод выведения значений на экран
{
    Console.WriteLine($"[{String.Join(", ", printingArray)}]");
}
int[] GetDivineArray(int[] array)                               //метод создания и заполнения нового массива значениями произведений пар по условию задачи
{
int size = (array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1);
int[] newArray = new int[size];
for (int i = 0; i < size; i++)
{
if (i != array.Length - i - 1)
newArray[i] = array[i] * array[array.Length - i - 1];
else newArray[i] = array[i];
}
return newArray;
}
int n = 7;
int[] givenArray = GetRandomArray(n);
PrintArray(givenArray);
int[] resultArray = GetDivineArray(givenArray);
PrintArray(resultArray);