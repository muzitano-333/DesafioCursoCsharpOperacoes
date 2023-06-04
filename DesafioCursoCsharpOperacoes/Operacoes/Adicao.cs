using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Operacoes
{
    public class Adicao
    {
        public double Somar(double valor1, double valor2) // cria um método com dois parâmetros, valor1 e valor2
        {
            double resultado = valor1 + valor2; // fórmula para realizar o cálculo
            return Math.Round(resultado, 2); // resultado do cálculo, arredondado para duas casas decimais, se necessário.

        }
    }
}
