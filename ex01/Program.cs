// Выяснить являются ли три числа сторонами треугольника
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if ( ((a + b) > c) && (a + c > b) && (b + c > a))
{
    Console.WriteLine("три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("три числа НЕ являются сторонами треугольника");
} 

