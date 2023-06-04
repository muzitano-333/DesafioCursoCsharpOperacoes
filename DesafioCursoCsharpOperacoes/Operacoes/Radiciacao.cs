using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Operacoes
{
    public class Radiciacao
    {
        public double Radiciar(double valor1, double valor2) // cria um método com dois parâmetros, valor1 e valor2
        {
            double resultado = Math.Pow(valor1, 1.0 / valor2); // fórmula para calcular a radiciação. 
            return Math.Round(resultado, 2); //retorna o resultado, arredondando para duas casas decimais, se necessário.
        }
    }
}
