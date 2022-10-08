void task29()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 1; i < size; i++)
    {
        for (int j = 0; j < size - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j+1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1]=temp;
            }
        }
    }
     PrintArray(numbers);

}

void FillArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Random random = new Random();
        num[i] = random.Next(-8,8);
    }

}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "\t");
    }
    Console.WriteLine();
}

 task29();
