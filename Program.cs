using System.Net.NetworkInformation;
using dio_deal_group_centric_net_Etapa_2.Models;


Console.WriteLine("=== Apresentação de Pessoas e Curso ===");
Pessoa p1 = new Pessoa { Nome = "Karina", Sobrenome = "Nascimento", Idade = 51 };
p1.Apresentar();

Pessoa p2 = new Pessoa { Nome = "João", Sobrenome = "Silva" };

Curso cursoDeProgramacao = new Curso { Nome = "Curso de Programação" };

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos();


Console.WriteLine("\n=== Leitura de Arquivo com Tratamento de Exceções ===");
try
{
    string[] linhas = File.ReadAllLines("Models/Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Favor analisar o seguinte aspecto: {ex.Message}");
}
finally
{
    Console.WriteLine("Processamento finalizado.");
}


Console.WriteLine("\n=== Exemplo de Tratamento de Exceções Personalizadas ===");
ExemploExcecao exemplo = new ExemploExcecao();
exemplo.Metodo1();


Console.WriteLine("\n=== Demonstração de Fila (Queue) ===");
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
Console.WriteLine("Elementos da fila:");
foreach (int item in fila)
{
    Console.WriteLine(item);
}
fila.Dequeue();

Console.WriteLine("Fila após remoção do primeiro elemento:");
foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n=== Demonstração de Pilha (Stack) ===");
Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(3);
pilha.Push(5);
Console.WriteLine("\nElementos da pilha:");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();

Console.WriteLine("Pilha após remoção do último elemento:");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

Console.WriteLine("\nElementos do dicionário:");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("\n=== Removendo e alterando elementos do dicionário ===");
estados.Remove("MG");
estados["SP"] = "São Paulo - Capital";
Console.WriteLine("Dicionário após remoção e alteração:");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("\n=== Consultando elemento do dicionário ===");
string chave = "BA";
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"\nEstado encontrado: {chave} - {estados[chave]}");
}
else
{
    Console.WriteLine($"\nEstado {chave} não encontrado no dicionário.");
}