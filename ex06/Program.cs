// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(1,10);
        }
    }
}

void SearchMatrix(int[,] arg, int n)
{
    int flag = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (n == arg[i,j]) 
            {
                Console.WriteLine("Число " + n + " находится на позиции: " + i + "," + j);
                flag = 1;
            }
        }
    }
    if (flag == 0) Console.WriteLine("заданое число не найдено");
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

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число которе необходимо найти: ");
int k = int.Parse(Console.ReadLine());

int[,] matrix = new int[m,n];

FillMatrix(matrix);

PrintMatrix(matrix);
SearchMatrix(matrix, k);