using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_deal_group_centric_net_Etapa_2.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome = string.Empty;
        private int _idade;
        public required string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public required string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}");
        }
    }
}