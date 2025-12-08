using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Grafos_Desafio
{
    internal class Program
    {
        public static void Main()
        {
            string entrada;

            while ((entrada = Console.ReadLine()) != null)
            {
                string[] partes = entrada.Split();

                int qtdCidades = int.Parse(partes[0]);
                int qtdArestas = int.Parse(partes[1]);

                Grafo grafoOnibus = new Grafo(qtdCidades);
                Grafo grafoAviao = new Grafo(qtdCidades);

                LerArestas(qtdArestas, grafoOnibus, grafoAviao);

                Dijkstra dijOnibus = new Dijkstra(qtdCidades, grafoOnibus);
                Dijkstra dijAviao = new Dijkstra(qtdCidades, grafoAviao);

                int custoOnibus = dijOnibus.CalcularMenorCusto();
                int custoAviao = dijAviao.CalcularMenorCusto();

                int menorCusto;

                if (custoOnibus < custoAviao)
                {
                    menorCusto = custoOnibus;
                }
                else
                {
                    menorCusto = custoAviao;
                }

                Console.WriteLine(menorCusto);
            }
        }
        private static void LerArestas(int quantidadeArestas, Grafo grafoOnibus, Grafo grafoAviao)
        {
            for (int i = 0; i < quantidadeArestas; i++)
            {
                string[] linha = Console.ReadLine().Split();

                int origem = int.Parse(linha[0]);
                int destino = int.Parse(linha[1]);
                int tipo = int.Parse(linha[2]);
                int custo = int.Parse(linha[3]);

                if (tipo == 0)
                {
                    grafoOnibus.AdicionarAresta(origem, destino, custo);
                }
                else
                {
                    grafoAviao.AdicionarAresta(origem, destino, custo);
                }
            }
        }
    }
}