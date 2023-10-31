using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codigos_Explorando_Ling_CSharp_WEX.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();

            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("Por favor, digite um nome!");
                }

                _nome = value;
            }
        }

        public int Idade
        {
            get => _idade;

            set 
            {
                if (value < 0) 
                {
                    throw new ArgumentException("A idade não pode ser menos que zero.");
                }

                _idade = value;
            }
        }

    }
}
