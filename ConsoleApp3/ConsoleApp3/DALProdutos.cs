using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    internal static class DALProdutos

    {
        private const string PathArquivo = @"\TEMP\LISTAPROD.csv";

        public static List<string> ObterTabelaProdutos()
        {
            var linhas = new List<string>();

            try
            {
                if (!File.Exists(PathArquivo))
                {
                    Console.WriteLine($"Arquivo não encontrado: {PathArquivo}");
                    return linhas;
                }

               
                foreach (var linha in File.ReadLines(PathArquivo))
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                        linhas.Add(linha);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Acesso negado ao arquivo: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro de E/S ao ler o arquivo: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao obter tabela de produtos: {ex.Message}");
            }

            return linhas;
        }
    }
}