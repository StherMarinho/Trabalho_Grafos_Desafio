using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Grafos_Desafio
{
    internal class Grafo
    {
        public Dictionary<int, int>[] ListaAdjacencia;

        public Grafo(int quantidadeCidades)
        {
            ListaAdjacencia = CriarListaAdjacencia(quantidadeCidades);
        }
        private Dictionary<int, int>[] CriarListaAdjacencia(int quantidade)
        {
            Dictionary<int, int>[] lista = new Dictionary<int, int>[quantidade + 1];

            for (int i = 1; i <= quantidade; i++)
            {
                lista[i] = new Dictionary<int, int>();
            }

            return lista;
        }
        public void AdicionarAresta(int origem, int destino, int custo)
        {
            if (!ListaAdjacencia[origem].ContainsKey(destino))
            {
                ListaAdjacencia[origem].Add(destino, custo);
            }
            else if (ListaAdjacencia[origem][destino] > custo)
            {
                ListaAdjacencia[origem][destino] = custo;
            }
        }
    }
}
