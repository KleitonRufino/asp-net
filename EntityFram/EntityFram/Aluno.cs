using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFram
{
    [Table("tbl_alunos")]
    class Aluno
    {
        public int AlunoID {get; set;}
        [Required]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
