using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_deal_group_centric_net_Etapa_2.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Favor analisar o seguinte aspecto: {ex.Message}");
            }
        }
        public void Metodo2()
        {
            try
            {
                Metodo3();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado: {ex.Message}");
            }
        }
        public void Metodo3()
        {
            try
            {
                Metodo4();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: {ex.Message}");
            }
        }
        public void Metodo4()
        {
            try
            {
                string[] linhas = File.ReadAllLines("Models/Arquivos/arquivoLeitura.txt");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}