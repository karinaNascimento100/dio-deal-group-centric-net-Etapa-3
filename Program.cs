using System.Net.NetworkInformation;
using dio_deal_group_centric_net_Etapa_2.Models;


Pessoa p1 = new Pessoa { Nome = "Karina", Sobrenome = "Nascimento", Idade = 51 };
p1.Apresentar();

Pessoa p2 = new Pessoa { Nome = "João", Sobrenome = "Silva" };



Curso cursoDeProgramacao = new Curso { Nome = "Curso de Programação" };

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos();