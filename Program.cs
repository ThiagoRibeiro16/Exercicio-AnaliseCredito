using System;

namespace Exercicio_AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            decimal ValorEmprestimo, rendaComprovada, valorParcela, confirmacaoDeEmprestimo, porcentagemRenda = 0.30m;
            Int32 quantidadeParcelas;



            Console.WriteLine("--------Simulação analise de credito-------\n=");
            Console.WriteLine("aceitamos empréstimos somente a partir de 1.000,00 R$\n");

            Console.Write("Digite o valor do empréstimo.....: ");
            ValorEmprestimo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nDigite a quantidade de parcelas desejadas.....: ");
            quantidadeParcelas = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nDigite o valor de sua renda mensal comprovada.....: ");
            rendaComprovada = Convert.ToDecimal(Console.ReadLine());


            valorParcela = ValorEmprestimo / quantidadeParcelas;

            confirmacaoDeEmprestimo = rendaComprovada * porcentagemRenda;

            if (ValorEmprestimo < 1000 || quantidadeParcelas < 0 || quantidadeParcelas > 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nValor do empréstimo (e / ou ) quantidade de parcela(s) inválida(s)\n");
                Console.ResetColor();

                Environment.Exit(-1);

            }

            else if (confirmacaoDeEmprestimo < valorParcela)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nNão foi possivel efetuar o empréstimo, o valor da(s) parcela(s) ({valorParcela:C2}) utrapassou 30% da renda mensal de ({confirmacaoDeEmprestimo:C2})");
                Console.ResetColor();


            }

            else

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nEmpréstimo efetuado com sucesso, você pagará {quantidadeParcelas} parcela(s) fixas de {valorParcela:C2} ");
                Console.ResetColor();


            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----------Obrigado por utilizar nosso programa-----------\n");
            Console.ResetColor();

























        }
    }
}
