using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class Turma
    {
        public int TurmaID { get; set; }
        public int Vagas { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Aluno> Alunos { get; set; }
    }
}
