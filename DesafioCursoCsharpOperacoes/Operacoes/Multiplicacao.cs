using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Operacoes
{
    public class Multiplicacao
    {
        public double Multiplicar(double valor1, double valor2) // cria um método com dois parâmetros, valor1 e valor2
        {
            double resultado = valor1 * valor2; // fórmula para multiplicação
            return Math.Round(resultado);  // resultado da operação, arredondado para duas casas decimais, se necessário
        }
    }
}
