using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Grafos_Desafio
{
    internal class Dijkstra
    {
        private const int INFINITO = int.MaxValue;
        private int quantidadeCidades;
        private Grafo grafo;
        public Dijkstra(int quantidadeCidades, Grafo grafo)
        {
            this.quantidadeCidades = quantidadeCidades;
            this.grafo = grafo;
        }
        public int CalcularMenorCusto()
        {
            int[] distancia = new int[quantidadeCidades + 1];
            bool[] visitado = new bool[quantidadeCidades + 1];
            int[] predecessor = new int[quantidadeCidades + 1];

            Inicializar(distancia, visitado, predecessor);

            distancia[1] = 0; // cidade inicial

            bool podeContinuar = true;

            for (int i = 1; i <= quantidadeCidades && podeContinuar; i++)
            {
                int cidadeAtual = ObterCidadeComMenorDistancia(distancia, visitado);

                if (cidadeAtual == -1)
                {
                    podeContinuar = false;
                }
                else
                {
                    visitado[cidadeAtual] = true;
                    RelaxarArestas(distancia, visitado, predecessor, cidadeAtual);
                }
            }
            return distancia[quantidadeCidades];
        }
        private void Inicializar(int[] distancia, bool[] visitado, int[] predecessor)
        {
            for (int i = 1; i <= quantidadeCidades; i++)
            {
                distancia[i] = INFINITO;
                visitado[i] = false;
                predecessor[i] = -1;
            }
        }
        private int ObterCidadeComMenorDistancia(int[] distancia, bool[] visitado)
        {
            int melhorCidade = -1;
            int menorDist = INFINITO;

            for (int cidade = 1; cidade <= quantidadeCidades; cidade++)
            {
                if (!visitado[cidade] && distancia[cidade] < menorDist)
                {
                    menorDist = distancia[cidade];
                    melhorCidade = cidade;
                }
            }

            return melhorCidade;
        }
        private void RelaxarArestas(int[] distancia, bool[] visitado, int[] predecessor, int cidadeAtual)
        {
            foreach (KeyValuePair<int, int> aresta in grafo.ListaAdjacencia[cidadeAtual])
            {
                int destino = aresta.Key;
                int custo = aresta.Value;

                if (!visitado[destino] && distancia[cidadeAtual] != INFINITO)
                {
                    int novaDist = distancia[cidadeAtual] + custo;

                    if (novaDist < distancia[destino])
                    {
                        distancia[destino] = novaDist;
                        predecessor[destino] = cidadeAtual;
                    }
                }
            }
        }
    }
}