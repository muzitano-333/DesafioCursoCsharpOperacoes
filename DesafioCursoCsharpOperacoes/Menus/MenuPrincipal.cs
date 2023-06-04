using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Menus
{
    public class MenuPrincipal 
    {
        public void MainMenu()
        {
            while (true) // continua mostrando o menu até que uma resposta seja dada.
            {
                Console.Clear(); // limpa a tela, facilitando a legibilidade
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("==              GERENCIADOR DE OPERAÇÕES ARITMÉTICAS 0.1a                                       ==");
                Console.WriteLine("==================================================================================================");                
                Console.WriteLine("== 1. PARA OPERAÇÕES DE ADIÇÃO                                                                  ==");
                Console.WriteLine("== 2. PARA OPERAÇÕES DE SUBTRAÇÃO                                                               ==");
                Console.WriteLine("== 3. PARA OPERAÇÕES DE MULTIPLICAÇÃO                                                           ==");
                Console.WriteLine("== 4. PARA OPERAÇÕES DE DIVISÃO                                                                 ==");
                Console.WriteLine("== 5. PARA OPERAÇÕES DE PORCENTAGEM                                                             ==");
                Console.WriteLine("== 6. PARA OPERAÇÕES DE POTENCIAÇÃO                                                             ==");
                Console.WriteLine("== 7. PARA OPERAÇÕES DE RADICIAÇÃO                                                              ==");
                Console.WriteLine("== 0. PARA ENCERRAR A APLICAÇÃO. (SAIR DO PROGRAMA.)                                            ==");
                Console.WriteLine("==================================================================================================");
                string resposta = Console.ReadLine(); //define a resposta como uma string, esperando que o usuário entre com o número correspondido no 'prompt'.

                switch (resposta.ToUpper())
                { 
                    case  "0":
                        Console.Clear();
                        Console.WriteLine("Aplicação Encerrando... Pressione qualquer tecla para fechar o terminal.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case "1":
                        MenuAdicao menuAdicao = new MenuAdicao(); // cria uma instância do MenuAdicao
                        menuAdicao.MostraMenuAdicao(); //chama o menu de operação correspondente.
                        break;
                    case "2":
                        MenuSubtracao menuSubtracao = new MenuSubtracao();
                        menuSubtracao.MostraMenuSubtracao();
                        break;
                    case "3":
                        MenuMultiplicacao menuMultiplicacao = new MenuMultiplicacao();
                        menuMultiplicacao.MostraMenuMultiplicar();
                        break;
                    case "4":
                        MenuDivisao menuDivisao = new MenuDivisao();
                        menuDivisao.MostraMenuDivisao();
                        break;
                    case "5":
                        MenuPorcentagem menuPorcentagem = new MenuPorcentagem();
                        menuPorcentagem.MostraMenuPorcentagem();
                        break;
                    case "6":
                        MenuPotenciacao menuPotenciacao = new MenuPotenciacao();
                        menuPotenciacao.MostraMenuPotenciacao();
                        break;
                    case "7":
                        MenuRadiciacao menuRadiciacao = new MenuRadiciacao();
                        menuRadiciacao.MostraMenuRadiciacao();
                        break;
                    default:
                        Console.WriteLine("Por favor, insira um número válido. Pressione qualquer tecla para tentar novamente."); // certifica-se de que um número válido seja inserido, ao mostrar esta mensagem e retornar ao começo da condição.
                        Console.ReadKey();
                        break; ;
                }

            }


        }
    }
}
