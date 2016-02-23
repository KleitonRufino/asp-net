using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class AlteraAluno
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                Aluno a = ctx.Alunos.Find(1);
                a.Nome = a.Nome + " ALTERADO";
                ctx.SaveChanges();

                Console.ReadLine();

            }
        }
    }
}
