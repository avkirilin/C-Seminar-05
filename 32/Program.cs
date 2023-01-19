//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицительные, и наоборот [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)      //метод получения массива заданной длины, заполняемый случайными числами
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
int[] ReverseArray(int count, int[] getArray)                   //метод заменяющий положительные значения в массиве на отрицательные и наоборот
{
    int[] anotherArray = new int[count];
    for (int i = 0; i < getArray.Length; i++)
    {
        anotherArray[i] = getArray[i] * (-1);
    }
    return anotherArray;
}
;
void PrintArray(int[] printingArray)                            //метод выведения значений на экран
{
    Console.WriteLine($"{String.Join(", ", printingArray)}");
}
System.Console.WriteLine("Введите кол-во значений в массиве");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Массив будет заполнен автоматически, на основании введенных вами предельных значений далее");
System.Console.WriteLine("Введите минимальное значение, принимаемое элементом в массиве");
int minNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение, принимаемое элементом в массиве");
int maxNum = Convert.ToInt32(Console.ReadLine());
maxNum++;
int[] myArray = GetRandomArray(n, minNum, maxNum);
PrintArray(myArray);
int[] negativeArray = ReverseArray(n, myArray);
PrintArray(negativeArray);