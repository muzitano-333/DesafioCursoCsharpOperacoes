using DesafioCursoCsharpOperacoes.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuPorcentagem 
    {
        public void MostraMenuPorcentagem()
        {
            Porcentagem porcentagem = new Porcentagem(); // cria uma instância da classe 'Porcentagem' como 'porcentagem'

            Console.Clear(); // limpa a tela, facilitando a legibilidade
            Console.WriteLine("Por favor, insira o primeiro termo:");
            double valor1;
            if(!double.TryParse(Console.ReadLine(), out valor1)) // tenta converter 'valor1' em 'double'. se conseguir, através de 'out valor1' adiciona o valor a valor1. se falhar, apresenta a condição de falha abaixo, e retorna ao início do menu.
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuPorcentagem();
                return;
            }

            Console.Clear();
            Console.WriteLine("Por favor, insira o segundo termo:");
            double valor2;
            if(!double.TryParse(Console.ReadLine(),out valor2))
            {
                Console.Clear();
                Console.WriteLine("\n\nValor inválido. Pressione qualquer tecla para retornar.");
                Console.ReadKey();
                MostraMenuPorcentagem();
                return;
            }

            Console.Clear();
            double resultado = porcentagem.Porcento(valor1, valor2); // utiliza o método Porcento da instancia porcentagem para realizar o cálculo.
            Console.WriteLine($"\n\n{valor1}% de {valor2} é igual à: {resultado}.\n\n\n\n--- Pressione qualquer tecla para retornar ao menu principal. ---");
            Console.ReadKey();
            return;
        }
    }
}
