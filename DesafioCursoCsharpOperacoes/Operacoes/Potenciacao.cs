using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCursoCsharpOperacoes.Operacoes
{
    public class Potenciacao
    {
        public double Elevar(double valor1, double valor2) // cria um método com dois parâmetros, valor1 e valor2
        {
            double resultado = Math.Pow(valor1, valor2); // fórmula para calcular a potenciação. ex.: valor1 elevado à valor2.
            return Math.Round(resultado, 2);  // resultado da operação, arredondado para duas casas decimais, se necessário
        }
    }
}
