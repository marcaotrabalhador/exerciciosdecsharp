

using System;

namespace MesesDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetor com os nomes dos meses do ano
            string[] mesesDoAno = {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto",
                "Setembro", "Outubro", "Novembro", "Dezembro"
            };

            // Solicitar ao usuário que digite um número entre 1 e 12
            int numeroMes;
            while (true)
            {
                Console.Write("Digite um número entre 1 e 12 para obter o nome do mês correspondente: ");
                if (int.TryParse(Console.ReadLine(), out numeroMes) && numeroMes >= 1 && numeroMes <= 12)
                    break;
                else
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 1 e 12.");
            }

            // Obter o nome do mês correspondente e exibi-lo
            string nomeMes = mesesDoAno[numeroMes - 1];
            Console.WriteLine($"O mês correspondente ao número {numeroMes} é: {nomeMes}.");
        }
    }
}
