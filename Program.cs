Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)

{
    Console.Write("Четное число: ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Нечетное число: ");
    Console.WriteLine(a);
}