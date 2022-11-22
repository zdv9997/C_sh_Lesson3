Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (num > 9999 && num < 100000)
    {
        if (num / 10000 == num % 10)
        {
            // Console.WriteLine(num / 10000);
            // Console.WriteLine(num % 10);
            if ((num / 1000) % 10 == (num % 100) / 10)
            {
                Console.WriteLine("Это число является палиндромом");
            }
            else
            {
                Console.WriteLine("Это число не является палиндромом");
            }
        }
        else
        {
            // Console.WriteLine(num / 10000);
            // Console.WriteLine(num % 10);
            Console.WriteLine("Это число не является палиндромом");
        }
        break;
    }
    else
    {
        Console.Write("Введите пятизначное число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
}