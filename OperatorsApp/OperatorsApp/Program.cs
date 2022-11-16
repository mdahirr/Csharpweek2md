int x = 5;
int y = 5;

int postfix = x++;
int prefix = ++y;

Console.WriteLine($"postfix: {postfix}, prefix {prefix}");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}