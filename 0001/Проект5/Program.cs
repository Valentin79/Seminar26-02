Random rnd = new Random();

int v = rnd.Next(10, 99);

Console.WriteLine(v);

int a = v/10;
int b = v%10;

if (a > b) Console.WriteLine(a);
else Console.WriteLine(b);
