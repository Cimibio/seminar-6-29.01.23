// Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int copy = n;

string bin = "";
while (copy >= 1)
{
    bin = copy % 2 + bin; 
    copy = copy / 2;
}

Console.WriteLine(bin);
