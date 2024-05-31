using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Data.Testes.Entities
{
    public class ValidacoesString
    {
        public int ContarCaracteresPalavra(string palavra)
        {
            return palavra.Length;
        }

        public bool PalavraDeveConterNaFrase(string texto, string palavraProcurada)
        {
            return texto.Contains(palavraProcurada);
        }
    }
}
