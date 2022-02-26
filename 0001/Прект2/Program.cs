Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
int aa = int.Parse(a);
Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
int bb = int.Parse(b);
Console.WriteLine($"{aa}, {bb}");
int result = aa*aa;

if (result == bb)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}
