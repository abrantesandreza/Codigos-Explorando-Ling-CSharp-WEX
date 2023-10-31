﻿using Codigos_Explorando_Ling_CSharp_WEX.Models;

Pessoa pessoa1 = new Pessoa(nome: "Andreza", sobrenome: "Abrantes");
Pessoa pessoa2 = new Pessoa(nome: "Andressa", sobrenome: "Abrantes");
Pessoa pessoa3 = new Pessoa(nome: "Auxi", sobrenome: "Santos");
Pessoa pessoa4 = new Pessoa(nome: "Aguinaldo", sobrenome: "Abrantes");
Pessoa pessoa5 = new Pessoa(nome: "Andre", sobrenome: "Abrantes");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.AdicionarAluno(pessoa3);
cursoDeIngles.AdicionarAluno(pessoa4);
cursoDeIngles.AdicionarAluno(pessoa5);


cursoDeIngles.ListarAlunos();
