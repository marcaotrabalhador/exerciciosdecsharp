using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[11];
            int produto = 0;
            int j= 0;
            for (int i = 1; i < n.Length;i++)
            {
                Console.WriteLine("Digite o " + i+"° número");
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite um número para multiplicar os anteriores: ");
            j = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i < n.Length; i++)
            {
                produto = n[i] * j;
                Console.WriteLine( n[i]+"x"+j+"="+produto);
            }
        }
    }
}
