using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Data.Testes.Entities
{
    public class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public List<int> RetornarSomenteNumerosPositivos(List<int> ListaInteiros)
        {
            return ListaInteiros.Where(x => x > 0).ToList();
        }

        public bool EhPar(int numero1)
        {
            return numero1 % 2 == 0;
        }
    }
}
