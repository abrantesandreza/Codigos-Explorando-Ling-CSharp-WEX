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
            Console.WriteLine($"Os alunos matriculados no curso de {Nome} são: ");
            
            for (int i = 1; i < Alunos.Count; i++)
            {
                //string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"Nº {i} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
        }

    }
}
