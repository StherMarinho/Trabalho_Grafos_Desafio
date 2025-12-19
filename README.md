# Trabalho – Desafio de Grafos com Dijkstra (C#)

Este projeto implementa a resolução de um problema de **menor caminho em grafos**, utilizando o **Algoritmo de Dijkstra**, considerando **dois tipos de transporte**: ônibus e avião.  
A solução calcula o menor custo em cada grafo e exibe o **menor valor entre eles**.

## Ideia Geral da Solução

- Cada cidade é representada como um **vértice**.
- Cada rota é representada como uma **aresta direcionada com peso (custo)**.
- São criados **dois grafos distintos**:
  - Grafo de rotas de ônibus
  - Grafo de rotas de avião
- O algoritmo de **Dijkstra** é executado separadamente em cada grafo.
- O programa imprime o **menor custo final** entre os dois meios de transporte.

## Estrutura do Projeto

Trabalho_Grafos_Desafio/
│

├── Program.cs // Leitura da entrada e execução do programa

├── Grafo.cs // Representação do grafo com lista de adjacência

└── Dijkstra.cs // Implementação do algoritmo de Dijkstra

## Tecnologias Utilizadas

- Linguagem: **C#**
- Conceitos:
  - Grafos
  - Lista de adjacência
  - Algoritmo de Dijkstra
  - Estruturas de dados básicas (`Dictionary`, arrays)

## Descrição das Classes

### Classe `Grafo`

Responsável por representar o grafo usando **lista de adjacência** baseada em `Dictionary<int, int>[]`.

**Responsabilidades:**
- Criar a lista de adjacência
- Adicionar arestas
- Atualizar o custo da aresta caso um caminho mais barato seja encontrado

### Classe `Dijkstra`

Implementa o **Algoritmo de Dijkstra** 

**Características:**
- Uso de `int.MaxValue` como infinito
- Controle de fluxo por variável booleana
- Métodos separados para:
  - Inicialização
  - Seleção da cidade com menor distância
  - Relaxamento das arestas

### Classe `Program`

Responsável por:
- Ler os dados da entrada padrão (EOF)
- Criar os grafos de ônibus e avião
- Executar o Dijkstra para cada grafo
- Exibir o menor custo final

