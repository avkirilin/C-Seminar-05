//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел 
//равна 29, сумма отрицаательных чисел равна -20.
Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)              //метод получения массива заданной длины, заполняемый случайными числами
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue);
        }
    return result;
    }
void PrintArray(int []ourArray)                                         //метод выведения значений на экран
  {
    Console.WriteLine($"{String.Join(", ", ourArray)}");
  }
int PlusValue(int[]gettingArray)                                        //метод нахождения суммы положительных значений
  {
    int lenghtArray = gettingArray.Length;
    int sumPlusValue = 0;
        for (int j = 0; j < lenghtArray; j++)
    {
      if (gettingArray[j] > 0) sumPlusValue += gettingArray[j]; 
    }
  return sumPlusValue;
  }
int MinusValue(int[]givingArray)                                        //метод нахождения суммы отрицательных значений
  {
    int lenghtThatArray = givingArray.Length;
    int sumMinusValue = 0;
        for (int k = 0; k < lenghtThatArray; k++)
    {
      if (givingArray[k] < 0) sumMinusValue += givingArray[k]; 
    }
  return sumMinusValue;
  }
   
    int[] array = GetRandomArray(12,-9,10);
    PrintArray(array);
    int plusNum = PlusValue(array);
    int minusNum = MinusValue(array);
    
  Console.WriteLine($"Сумма положительных значений массива будет равна: {plusNum}");
  Console.WriteLine($"Сумма отрицательных значений массива будет равна: {minusNum}");
