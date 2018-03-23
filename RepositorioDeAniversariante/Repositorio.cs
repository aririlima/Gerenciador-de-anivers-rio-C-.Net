using Aniversariante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioDeAniversariante
{
    public class Repositorio
    {
        public List<Pessoa> anList = new List<Pessoa>();
        public Pessoa p = new Pessoa();


        public void addAniversariante(string nome, string sobrenome, DateTime aniversario) {
            try
            {
                anList.Add(new Pessoa(nome, sobrenome, aniversario));

                Console.WriteLine("Aniversariante " + nome + " cadastrado(a) com sucesso.");
                Console.WriteLine("");

                foreach (var aniversariante in anList)
                {

                    if (aniversariante.nome.Equals(nome))
                    {
                        Console.WriteLine(aniversariante.nome + " " + aniversariante.sobrenome);
                        Console.WriteLine(aniversariante.aniversario.ToShortDateString());
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aniversariante não cadastrado(a).");
                Console.WriteLine("");
            }

        }

        public void buscaProNome(string nome0)
        {
            try
            {
                foreach (var aniversariante in anList)
                {
                    if (aniversariante.nome.Equals(nome0))
                    {
                        Console.WriteLine("Nome :" + aniversariante.nome + " " + aniversariante.sobrenome);
                        Console.WriteLine("Nascimento: " + aniversariante.aniversario.ToShortDateString());
                        Console.WriteLine(aniversariante.nome + " esta no seu " + p.diasDeVida(aniversariante) + "º dia de vida");
                        Console.WriteLine("Faltam " + p.quantoFalta(aniversariante) + " dias para o próximo aniversário de " + aniversariante.nome);
                        Console.WriteLine("");

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Esse aniversariante não está cadastrado.");
                Console.WriteLine("");
            }

        }

        public void buscaTodos() {
            try
            {
                foreach (var aniversariante in anList)
                {

                    Console.WriteLine("Nome :" + aniversariante.nome + " " + aniversariante.sobrenome);
                    Console.WriteLine("Nascimento: " + aniversariante.aniversario.ToShortDateString());
                    Console.WriteLine(aniversariante.nome + " esta no seu " + p.diasDeVida(aniversariante) + "º dia de vida");
                    Console.WriteLine("Faltam " + p.quantoFalta(aniversariante) + " dias para o próximo aniversário de " + aniversariante.nome);
                    Console.WriteLine("");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não existe aniversariante cadastrado.");
                Console.WriteLine("");
            }
        }


        public void deletAniversariante(string nome1) {
            try
            {
                foreach (var aniversariante in anList)
                {
                    if (aniversariante.nome.Equals(nome1))
                    {
                        anList.Remove(aniversariante);
                        Console.WriteLine("Aniversariante excluido(a) com sucesso.");
                        Console.WriteLine("");

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aniversariante NÃO pode ser excluido(a). Tente novamente.");
                Console.WriteLine("");
            }
        }
    }
}
