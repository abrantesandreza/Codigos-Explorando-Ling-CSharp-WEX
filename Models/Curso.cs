using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codigos_Explorando_Ling_CSharp_WEX.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        
        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() 
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno) 
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine("Os alunos matriculados são: ");
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}
