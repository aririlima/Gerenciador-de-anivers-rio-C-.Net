using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversariante
{
    public class Pessoa
    {

        public string nome;
        public string sobrenome;
        public DateTime aniversario;

        public Pessoa() { }

        public Pessoa(string nome, string sobrenome, DateTime aniversario)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.aniversario = aniversario;

        }


        public int diasDeVida(Pessoa an)
        {

            DateTime hj = DateTime.Today;

            TimeSpan diasRestantes = hj - an.aniversario;

            return diasRestantes.Days;
        }


        public int quantoFalta(Pessoa an)
        {

            DateTime hj = DateTime.Today;

            int idade = hj.Year - an.aniversario.Year;

            DateTime proximo = an.aniversario.AddYears(idade + 1);

            TimeSpan diasDeVida = proximo - hj;

            int faltam = diasDeVida.Days;

            return faltam;
        }
    }
}
