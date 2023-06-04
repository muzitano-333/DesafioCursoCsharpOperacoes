using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuSubtracao
    {
        Subtracao subtracao = new Subtracao(); // cria uma instância da classe 'Subtracao' como 'subtracao'

        public void MostraMenuSubtracao()
        {

            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("\n\nPor favor, insira o primeiro termo da subtração:");
            double valor1;
            if (!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuSubtracao();
                return;

            }

            Console.Clear();
            Console.WriteLine("\n\nPor favor, insira o segundo termo da subtração:");
            double valor2;
            if (!double.TryParse(Console.ReadLine(),out valor2) )
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuSubtracao();
                return;
            }

            Console.Clear();


            double resultado = subtracao.Subtrair(valor1, valor2); // utiliza o método Subtrair da instancia subtracao para realizar o cálculo.
            Console.WriteLine($"\n\nO resultado da subtração de {valor1} e {valor2} é igual à {resultado}.\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadLine();
            return;


        }

    }
}
