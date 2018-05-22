using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çizge
{
    class KruskalAlgorithm
    {
        int verticesCount = 0;
        int edgesCount = 0;
        int count = 0;
        public int[,] tree;
        Graph graph;


        public KruskalAlgorithm(int verticesCount,int edgesCount)
        {
            this.verticesCount = verticesCount;
            this.edgesCount = edgesCount;
            graph= CreateGraph(verticesCount, edgesCount);
        }

        public void Add(int source,int dest,int weight)
        {
            if (count == edgesCount)
                return;
            graph.edge[count].Source = source;
            graph.edge[count].Destination = dest;
            graph.edge[count].Weight = weight;
            count++;
        }

        public struct Edge
        {
            public int Source;
            public int Destination;
            public int Weight;
        }

        public struct Graph
        {
            public int VerticesCount;
            public int EdgesCount;
            public Edge[] edge;
        }

        public struct Subset
        {
            public int Parent;
            public int Rank;
        }

        public  Graph CreateGraph(int verticesCount, int edgesCoun)
        {
            Graph graph = new Graph();
            graph.VerticesCount = verticesCount;
            graph.EdgesCount = edgesCoun;
            graph.edge = new Edge[graph.EdgesCount];

            return graph;
        }

        private  int Find(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        public  void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else
            {
                subsets[yroot].Parent = xroot;
                ++subsets[xroot].Rank;
            }
        }

        public  void Print(Edge[] result, int e)
        {
            tree = new int[verticesCount, verticesCount];
            for (int i = 0; i < e; ++i)
                tree[result[i].Source, result[i].Destination]= 1;
        }

        public  void Kruskal()
        {
            int verticesCount = graph.VerticesCount;
            Edge[] result = new Edge[verticesCount];
            int i = 0;
            int e = 0;

            Array.Sort(graph.edge, delegate (Edge a, Edge b)
            {
                return a.Weight.CompareTo(b.Weight);
            });

            Subset[] subsets = new Subset[verticesCount];

            for (int v = 0; v < verticesCount; ++v)
            {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }

            while (e < verticesCount - 1)
            {
                Edge nextEdge = graph.edge[i++];
                int x = Find(subsets, nextEdge.Source);
                int y = Find(subsets, nextEdge.Destination);

                if (x != y)
                {
                    result[e++] = nextEdge;
                    Union(subsets, x, y);
                }
            }

            Print(result, e);
        }
    }
}
