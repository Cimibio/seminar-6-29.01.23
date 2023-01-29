// Показать числа Фибоначчи меньшие заданного числа N
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int[] fib = new int[N];

for (int i = 0; i < N; i++)
{
    if (i == 0 || i == 1) fib[i] = 1;
    else fib[i] = fib[i-1] + fib[i - 2];
    if (fib[i] >= N) break;
    else Console.WriteLine(fib[i]);
}