// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int a = InputInt("Введите число A ");
int b = InputInt("Введите число B ");
int res = 1;
for(int i=1; i<=b; i++)
{
    res = res*a;
}
Console.WriteLine(res);

int InputInt (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
