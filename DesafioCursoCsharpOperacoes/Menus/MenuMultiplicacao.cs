using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuMultiplicacao 
    {
        public void MostraMenuMultiplicar()
        {
            Multiplicacao multiplicacao = new Multiplicacao(); // cria uma instância da classe 'Multiplicacao' como 'multiplicacao'

            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("\n\nPor favor, entre o primeiro termo da multiplicação:");
            double valor1;
            if (!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.WriteLine("\n\nValor Inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuMultiplicar();
                return;
            }

            Console.Clear();
            Console.WriteLine("\n\nPor favor, entre o segundo termo da multiplicação:");
            double valor2;
            if(!double.TryParse(Console.ReadLine(),out valor2))
            {
                Console.WriteLine("\n\nValor Inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuMultiplicar();
                return;
            }

            double resultado = multiplicacao.Multiplicar(valor1, valor2); // utiliza o método Multiplicar da instancia multiplicacao para realizar o cálculo.

            Console.Clear();
            Console.WriteLine($"\n\nO resultado de {valor1} x {valor2} é: {resultado}.\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;

        }
    }
}
