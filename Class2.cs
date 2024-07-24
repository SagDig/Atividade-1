using System;

int nun;

Console.WriteLine("Digite um número");
Convert.ToInt32(Console.Read(nun));

if (nun % 2 == 0)
{
    Console.WriteLine("O numero ", nun, " é par");

} else
{
    Console.WriteLine("O numero ", nun, " é impar");
}
