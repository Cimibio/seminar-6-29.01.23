// В двумерном массиве n×k заменить четные элементы на противоположные
void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(-10,10);
        }
    }
}
void NegateMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (arg[i,j] % 2 == 0)
            {
                arg[i,j] = arg[i,j] * -1;
            }
        }
    }
}

void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число n: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

FillMatrix(matrix);

Console.WriteLine("Массив до преобразования");

PrintMatrix(matrix);

Console.WriteLine("Массив после преобразования");
NegateMatrix(matrix);
PrintMatrix(matrix);
