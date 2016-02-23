using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                Aluno a1 = new Aluno
                {
                    Nome = "Amanda Guerra",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Amalera",
                        Numero = 1789,
                        CEP = "00157-001"
                    }
                };
                Aluno a2 = new Aluno
                {
                    Nome = "Marcelo Martins",
                    Endereco = new Endereco
                    {
                        Logradouro = "Rua Zaul",
                        Numero = 1019,
                        CEP = "00157-001"
                    }
                };
                Professor p1 = new Professor {
                     Nome = "Jonas Hirata",
                     Endereco = new Endereco
                     {
                         Logradouro = "Rua Mervelha",
                         Numero = 8336,
                         CEP = "00157-001"
                     }
                };
                Turma t1 = new Turma {
                    Vagas = 10,
                    Alunos = new List<Aluno>()
                };

                t1.Professor = p1;
                t1.Alunos.Add(a1);
                t1.Alunos.Add(a2);

                ctx.Turmas.Add(t1);
                ctx.SaveChanges();
            }
        }
    }
}
