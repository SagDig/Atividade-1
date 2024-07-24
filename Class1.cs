using System;

int n1, n2, res;
char ope;

Console.WriteLine("EScolha um primeiro número uma operação e um segundo número:");
Console.Write("Número 1: ");
Convert.ToInt32(Console.ReadLine(n1));

Console.Write("Operação: ");
Convert.ToInt32(Console.ReadLine(ope));

Console.Write("Número 2: ");
Convert.ToInt32(Console.ReadLine(n2));

if (ope == '+')
{
    Console.WriteLine(res = n1 + n2);
} else if (ope == '-')
{
    Console.WriteLine(res = n1 - n2);
} else if (ope == '*')
{
    Console.WriteLine(res = n1 * n2);
} else if (ope == '/')
{
    Console.WriteLine(res = n1 / n2);
}