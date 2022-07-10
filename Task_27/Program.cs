//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("ВВедите число ");
int n = Convert.ToInt32(Console.ReadLine());
int a=0;
int count = 0;
int sum = 0;
while (n>0)
{
    a=n%10;
    sum = sum + a;
    n = n/10;
    count++;
}
Console.WriteLine("Сумма цифр в числе равна " + sum);
