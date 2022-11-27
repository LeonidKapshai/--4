Console.WriteLine("Введите чило:");
var num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Getsum(num));

int Getsum(int num)
{
    int sum = num % 10;
    while (num > 10)
    {
        num = num / 10;
        sum = sum + (num % 10);
    }
    return sum;
}
