using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuAdicao 
    {
        public void MostraMenuAdicao()
        {
            Adicao adicao = new Adicao(); // cria uma instância da classe 'Adicao' como 'adicao'
            
            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("\n\nPor Favor, entre com o primeiro termo da soma:");

            double valor1;
            if (!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuAdicao(); 
                return;
            }

            Console.Clear();
            Console.WriteLine("\n\nPor favor, entre com o segundo termo da soma:");

            double valor2;
            if (!double.TryParse(Console.ReadLine(), out valor2))
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuAdicao();
                return;
            }


            double resultado = adicao.Somar(valor1, valor2); // utiliza o método Somar da instancia adicao para realizar o cálculo.

            Console.Clear();
            Console.WriteLine($"\n\nO resultado de {valor1} + {valor2}  é: {resultado}\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;


        }
    }
}
