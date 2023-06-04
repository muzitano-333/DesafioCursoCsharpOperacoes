using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuRadiciacao
    {
        Radiciacao radiciacao = new Radiciacao(); // cria uma instância da classe 'Radiciacao' como 'radiciacao'

        public void MostraMenuRadiciacao()
        {

            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("Por favor, entre o primeiro termo.");
            double valor1;
            if(!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuRadiciacao();
                return;
            }

            Console.Clear();
            Console.WriteLine("\n\nPor favor, entre o segundo termo.");
            double valor2;
            if(!double.TryParse(Console.ReadLine(),out valor2))
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuRadiciacao();
                return;
            }
            Console.Clear();

            double resultado = radiciacao.Radiciar(valor1, valor2); // utiliza o método Radiciar da instancia radiciacao para realizar o cálculo.
            Console.WriteLine($"\n\nO resultado desta operação é: {resultado}\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;

        }

    }
}
