void task25()
{
    Console.WriteLine("Введите число: "); 
    
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень: "); 
    int count = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for (int i =1; i <= count; i++)
    {
        result *= number1;
    }  

    Console.Write($"{result}");
}
task25();