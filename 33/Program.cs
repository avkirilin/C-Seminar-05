//Задайте массив. Напишите программу, которая определяет,присутствует ли заданное значение в массиве?

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
void PrintArray(int[] printingArray)                            //метод выведения значений на экран
{
    Console.WriteLine($"{String.Join(", ", printingArray)}");
}
int CheckingValue(int[] array, int checkValue)                  //метод проверки на наличие значения в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (checkValue == array[i])
        {
            System.Console.WriteLine("Да! Данное значение присутствует в текущем массиве");
            break;
        }
        else
        {
            System.Console.WriteLine("Нет! Данное значение отсутствует в текущем массиве");
            break;
        }
    }
    return checkValue;
}

System.Console.WriteLine("Введите кол-во значений в массиве");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Массив будет заполнен автоматически, на основании введенных вами предельных значений далее");
System.Console.WriteLine("Введите минимальное значение, принимаемое элементом в массиве");
int minNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение, принимаемое элементом в массиве");
int maxNum = Convert.ToInt32(Console.ReadLine());
maxNum++;
System.Console.WriteLine("Введите число для проверки, есть ли оно в полученном массиве?");
int ourValue = Convert.ToInt32(Console.ReadLine());
int[] ourArray = GetRandomArray(n, minNum, maxNum);
PrintArray(ourArray);
CheckingValue(ourArray, ourValue);