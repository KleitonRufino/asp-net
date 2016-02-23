using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class RemoveAluno
    {
        static void main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                Aluno a = ctx.Alunos.Find(1);
                ctx.Alunos.Remove(a);

                ctx.SaveChanges();

                Console.ReadLine();
            }
        }
    }
}
