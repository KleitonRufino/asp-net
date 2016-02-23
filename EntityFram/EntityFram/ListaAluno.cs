using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class ListaAluno
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                var consulta = from a in ctx.Alunos select a;
                foreach(Aluno a in consulta)
                {
                    Console.WriteLine("Nome: " + a.Nome);
                    Console.WriteLine("Logradouro: " + a.Endereco.Logradouro);
                    Console.WriteLine("Número: " + a.Endereco.Numero);
                    Console.WriteLine("CEP: " + a.Endereco.CEP);
                    Console.WriteLine("------------");
                }
                Console.ReadLine();
            }
        }
    }
}
