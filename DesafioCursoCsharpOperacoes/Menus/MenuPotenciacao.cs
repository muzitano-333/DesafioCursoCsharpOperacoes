using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuPotenciacao
    {
        Potenciacao potenciacao = new Potenciacao(); // cria uma instância da classe 'Potenciacao' como 'potenciacao'

        public void MostraMenuPotenciacao()
        
        {

            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("\n\nPor favor, insira o primeiro termo:");
            double valor1;
            if(!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuPotenciacao();
                return;
            }

            Console.Clear();
            Console.WriteLine("\n\nPor favor, insira o primeiro termo:");
            double valor2;
            if(!double.TryParse(Console.ReadLine(),out valor2))
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuPotenciacao();
                return;
            }

            Console.Clear();

            double resultado = potenciacao.Elevar(valor1, valor2); // utiliza o método Elevar da instancia potenciacao para realizar o cálculo.
            Console.WriteLine($"\n\n {valor1} elevado à {valor2} é igual à {resultado}.\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;
        
        
        }
    }
}
