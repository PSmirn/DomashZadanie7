void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(0,9);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4,6);
    int colums = random.Next(4,6);
    int[,] array = new int[rows, colums];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine();
    SortArray(array);
    PrintArray(array);
}
void Zadacha56()
{
    int rows = 6;
    int colums = 4;
    int[,] array = new int[rows, colums];
    FillArray(array);
    PrintArray(array);
    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i,j];
            }
        return sumLine;
    }

    int InputNumbers(string input)
    {
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
    }
}
void Zadacha58()
{
    int rows = 4;
    int colums = 4;
    int[,] array = new int [rows,colums];
    int a = 1;
    int i = 0;
    int j = 0;
    while (a <= 16)
    {
        array[i, j] = a;
        a++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    PrintArray(array);
}
Zadacha58();



