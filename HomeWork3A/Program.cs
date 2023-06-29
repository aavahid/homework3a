int number1, number2; // 1

do
{
    Console.Write("1. ədədi girin: "); // 1
    number1 = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("2. ədədi girin: "); // 1
    number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 >= number2)
    {
        Console.WriteLine("Yenidən girin. (Birinci ədəd ikincidən kiçik olmalıdır)"); // 1
        Console.WriteLine(" "); // 1
    }
} while (number1 >= number2); // n

int sum = 0; // 1

for (int i = number1; i <= number2; i++)
{
    sum += i; // n
}

Console.WriteLine("Toplam: " + sum); // 1

// 7 + n + n = O(n)