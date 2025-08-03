using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace dio_deal_group_centric_net_Etapa_2.Models
{
    public class Curso
    {
        public required string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; } = new List<Pessoa>();

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunos()
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
            Console.WriteLine($"Alunos do curso de {Nome}:");
            foreach (Pessoa aluno in Alunos)

                Console.WriteLine(aluno.NomeCompleto);
        }

    }
}
