using Aniversariante;
using RepositorioDeAniversariante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeAniversariantes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> anList = new List<Pessoa>();
            bool sistema = true;
            Pessoa an = new Pessoa();
            Repositorio r = new Repositorio();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("***** AGENDA DE ANIVERSÁRIOS *****");
                Console.WriteLine("");
                Console.WriteLine("Digite o numero da opção que deseja acessar: ");
                Console.WriteLine("1 - Adicionar aniversariante ");
                Console.WriteLine("2 - Pesquisar aniversariante ");
                Console.WriteLine("3 - Exibir todos os aniversariantes ");
                Console.WriteLine("4 - Excluir aniversariante ");
                Console.WriteLine("5 - Sair ");

                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o primeiro nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome: ");
                        string sobrenome = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento no formato (dd/mm/aaaa): ");
                        DateTime aniversario = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        r.addAniversariante(nome, sobrenome, aniversario);

                        break;
                    case 2:
                        Console.WriteLine("Digite o primeiro nome: ");
                        string nome0 = Console.ReadLine();
                        Console.WriteLine("");

                        r.buscaProNome(nome0);

                        break;
                    case 3:
                        r.buscaTodos();

                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro nome: ");
                        string nome1 = Console.ReadLine();
                        Console.WriteLine("");

                        r.deletAniversariante(nome1);

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida.");
                        Console.WriteLine("");

                        break;
                }

            } while (sistema);

        }
    }
}
