//Задайте одномерный массив из 123 случайных чисел. Найдите кол-во элементов массива, значения которых лежат в отрезке [10, 99].

Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)              //метод получения массива заданной длины, заполняемый случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
void PrintArray(int[] printingArray)                                    //метод выведения значений на экран
{
    Console.WriteLine($"{String.Join(", ", printingArray)}");
}
int CountInRange(int[] ourArray)    //метод вычисления кол-ва элементов, лежащих в заданном промежутке значений
{
    int count = 0;
    int minimumValue = 10;
    int maximumValue = 99;
    for (int i = 0; i < ourArray.Length; i++)
    {
        if (ourArray[i] >= minimumValue && ourArray[i] <= maximumValue) count += +1;
    }
    return count;
}
System.Console.WriteLine("Массив будет заполнен автоматически, на основании введенных вами предельных значений далее");
System.Console.WriteLine("Введите минимальное значение, принимаемое элементом в массиве");
int minNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение, принимаемое элементом в массиве");
int maxNum = Convert.ToInt32(Console.ReadLine());
int lenghtArray = 123;
if (minNum < maxNum)
{
    int[] array = GetRandomArray(lenghtArray, minNum, maxNum);
    PrintArray(array);
    int sumValue = CountInRange(array);
    System.Console.WriteLine($"Кол-во элементов, лежащих в диапазоне от 10 до 99, для данного массива равно: {sumValue}");
}
else
{
    System.Console.WriteLine("Ошибка! Минимальное значение меньше, либо равно максимальному");
}