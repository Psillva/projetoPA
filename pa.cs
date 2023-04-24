using System;

class Program
{
    public static void Main()
    {
        int ao, r, n, i = 0, an;

        Console.WriteLine("Digite o prmeiro número da PA (a0): ");
        ao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a razão da PA (r): ");
        r = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite quantos elementos você quer nesta PA (n): ");
        n = int.Parse(Console.ReadLine());

        while (i < n; )
        {
            i = i + 1;
            an = ao + (i - 1) * r;

            Console.WriteLine("{0}", an);
        }


    }
}