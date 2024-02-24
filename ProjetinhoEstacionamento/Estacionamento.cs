using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetinhoEstacionamento
{
    public class ManipuladorArquivoDeTexto(string? manipuladorArquivo)
    {
        private readonly string? manipuladorArquivo = manipuladorArquivo;

        // METODO PARA ADICIONAR
        public void AdicionarStringAoArquivo(string texto)
        {
            //TRY VAI VERIFICAR SE A STRING FOI ADIOCIONADA COM SUCESSO OU NÃO
            try
            {
                using (StreamWriter escrever = new(manipuladorArquivo, true))
                {
                    escrever.WriteLine(texto);
                }
                Console.WriteLine("Placa Adicionada com Sucesso");
            } 
            //CATH VAI APRESENTAR A MENSAGEM DA EXCEPTION PRO CÓDIGO NÃO QUEBRAR
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar a placa no arquivo {ex.Message}");
            }
        }

        public void RemoverStringDoArquivo(string texto)
        {
            try
            {
                List<string> linhas = new(File.ReadLines(manipuladorArquivo));
                linhas.Remove(texto);
                File.WriteAllLines(manipuladorArquivo, linhas);
                Console.WriteLine("String da placa removida com sucesso do arquivo");
            } catch (Exception ex)
            {
                Console.WriteLine($"A String não pôde ser removida {ex.Message}");
            }
        }

        public void ImprimirConteudoArquivo()
        {
            try
            {
                string[] linhas = File.ReadAllLines(manipuladorArquivo);
                Console.WriteLine("\nLista de veículos estacionados \n");
                foreach (string linha in linhas) 
                {
                    Console.WriteLine(linha);
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Falha ao imprimir{ex.Message}");
            }
        }

    }
}