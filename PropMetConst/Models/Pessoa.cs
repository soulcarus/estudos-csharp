using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropMetConst.Models
{
    public class Pessoa
    {
        //NAO PODEMOS ACESSAR O PRIVATE COM OUTRO ARQUIVO!
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome) // Construtores sempre tem o mesmo nome da classe`
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 

        { 
            //BODY EXPRESSION =>
            get => _nome.ToUpper(); //MESMA FUNCIONALIDADE DE UM return  _nome.ToUpper()

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade; 

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}

