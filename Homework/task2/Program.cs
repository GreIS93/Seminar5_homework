// Показать числа Фибоначчи
Console.WriteLine("Введите количество чисел Фибоначчи");
int count = int.Parse(Console.ReadLine());
double F(int n)
{
    if (n == 1 || n == 2) return 1;
    else return F(n - 1) + F(n - 2);
}

for (int i = 1; i <= count; i++)
{
    Console.WriteLine($"F{i} = {F(i)}");
}