//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("Введите число:");
string a = Console.ReadLine();
int aa = int.Parse(a);

int first = aa%7;
int second = aa%23;

if(first == 0 & second == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
