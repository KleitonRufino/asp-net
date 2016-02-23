using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace EntityFram
{
    class AlunoRepository
    {
        DbContext context; 

        public AlunoRepository(DbContext context)
        {
            this.context = context;
        }
            
        public void Adiciona(Aluno a)
        {
            context.Set<Aluno>().Add(a);
            context.SaveChanges();
        }
         
        public Aluno Busca(int id)
        {
           return context.Set<Aluno>().Find(id);
        }
        
        public List<Aluno> List()
        {
            var consulta = from a in context.Set<Aluno>() select a;
            return consulta.ToList();
        }    


    }
}
