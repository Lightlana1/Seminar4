void task27()
{
    Console.WriteLine("Введите число: "); 
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 10)
    {
        Console.Write($"{number}");
    }

    else
    {
        int sum = 0;
        while (number > 0) 
        {
            sum = sum + number % 10;
            number = number / 10;
        }
         Console.Write($"{sum}");
    }

}

task27();