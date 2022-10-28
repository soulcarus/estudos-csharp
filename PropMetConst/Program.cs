//PROPRIEDADES, METODOS E CONSTRUTORES

//ESTE ARQUIVO CONTEM APENAS AS PROPRIEDADES, OS ARQUIVOS SEGUINTES CONTEM OS DEMAIS ASSUNTOS

//Propriedades: Membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.

using PropMetConst.Models;

//private, public, prop, get, set, .ToUpper(), throw new Argument Exception, =>
//Métodos: um bloco de código que contém uma série de instruções

Pessoa p1 = new Pessoa(nome:"João Ícaro",sobrenome:"Moreira");
Pessoa p2 = new Pessoa(nome:"Samuel",sobrenome:"Ribeiro Araujo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

//Construtores: permitem que o programador defina valores padrão, limite a instancia e grave codigos flexiveis e faceis de ler;