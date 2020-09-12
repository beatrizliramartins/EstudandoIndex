using System;

namespace IndexDeNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = ObterNomes();

            for (int i = 0; i < nomes.Length; i++)
            {
                for (int j = 0; j < nomes[i].Length; j++)
                {
                    if (nomes[i][j] == ' ')
                    {
                        break;
                    }
                    Console.Write(nomes[i][j]);
                }
                Console.WriteLine();
            }
        }

       
        static string[] ObterNomes()
        {
            string[] nomes = {
              "Alexandra Rayane Farias Santos Silva",
              "Cleonice Valéria de Oliveira Celestino",
              "Jerson Luiz Silva de Brito",
              "Beatriz Lira Martins"
            };
            return nomes;
        }
    }
}
