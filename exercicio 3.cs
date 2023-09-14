using System;

namespace Erro_Crasso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[11];
            int[] n1 = new int[11];
            int produto = 0;
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Digite o " + i + "° número: ");
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Agora o segundo array");
            for (int i =1; i <=10; i++)
            {
                Console.WriteLine("Digite o " + i + "° número: ");
                n1[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Resultado da multiplicação entre os arrays: ");

            for (int i =1; i <= 10; i++)
            {
                produto = n[i] * n1[i];
                Console.WriteLine(n[i] + "x" + n1[i] + "=" + produto);
            }
        }
    }
}
