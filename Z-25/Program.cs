Console.WriteLine("Введите чило:");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Getsum(num2));

int Getsum (int num) 
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
{
    sum = sum * num1;
}
return sum;
}
