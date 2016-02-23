using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFram
{
    class InsereAluno
    {
       static void Main(string[] args)
        {
            using (var ctx = new MyContext())
            {
                Console.WriteLine("Digite o nome do aluno: ");
                 string nome = Console.ReadLine();

                Console.WriteLine("Digite o logradouro do endereço do aluno: ");
                string logradouro = Console.ReadLine();

                Console.WriteLine("Digite o número do endereço do aluno");
                int numero = System.Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o CEP do endereço do aluno");
                string cep = Console.ReadLine();

                Aluno a = new Aluno
                {
                    Nome = nome,
                    Endereco = new Endereco
                    {
                        Logradouro = logradouro,
                        Numero = numero, 
                        CEP = cep
                    }
                };

                ctx.Alunos.Add(a);
                ctx.SaveChanges();
            }
        }

    }
}
