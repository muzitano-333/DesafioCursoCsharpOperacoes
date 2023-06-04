using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuDivisao
    {
        public void MostraMenuDivisao()
        {
            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Divisao divisao = new Divisao(); // cria uma instância da classe 'Divisao' como 'divisao'

            Console.WriteLine("\n\nEntre com o primeiro termo da divisão:");

            double valor1;
            if (!double.TryParse(Console.ReadLine(), out valor1) || valor1 == 0) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu. Também verifica se valor1 é igual a 0.
            {
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuDivisao();
                return;
            }

            
            else
            {
                Console.Clear();
                Console.WriteLine($"\n\nPor quanto deseja dividir {valor1}?");
            }

            double valor2;
            if (!double.TryParse(Console.ReadLine(), out valor2) || valor2 == 0)
            {
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuDivisao();
                return;
            }

            Console.Clear();
            double resultado = divisao.Dividir(valor1, valor2); // utiliza o método Dividir da instancia divisao para realizar o cálculo.
            Console.WriteLine($"\n\nO Resultado da divisão entre {valor1} e {valor2} é: {resultado}\n\n\n\n\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;
        }
    }
}