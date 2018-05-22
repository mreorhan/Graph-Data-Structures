using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Project
{
    public class Graph
    {
        public int[,] matris;
        public int size;
        public int[,] tree;
        public ArrayList yollar;

        private KruskalAlgorithm Kruskal;
        

        public Graph(int size)
        {
            this.size = size;
            yollar = new ArrayList();
            matris = new int[size, size];
            tree = new int[size, size];

            Kruskal = new KruskalAlgorithm(size, size * 2);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matris[i, j] = 1000;
        }

        public void Ekle(int a, int b, int weight)
        {
            matris[a, b] = weight;
            matris[b, a] = weight;

            Kruskal.Add(a, b, weight);

            Edge yol = new Edge(a, b, weight);            
            yollar.Add(yol);
        }

       

        public int[,] KruskalGraph()
        {
            this.Kruskal.Kruskal();
            return this.Kruskal.tree;
        }

        public int Dijktras(int a, int b)
        {
            int[] distances = new int[size];

            Distance(distances, a);

            return distances[b];
        }

        public void Distance(int[] D, int a)
        {
            int w, v, min;

            bool[] visited = new bool[size];

            D[a] = 0;
            for (v = 0; v < size; v++)
            {
                if (v != a)
                {
                    visited[v] = false;
                    D[v] = matris[a, v];
                }
            }

            for (int i = 0; i < size; ++i)
            {
                min = 1000;
                for (w = 0; w < size; w++)
                    if (!visited[w])
                        if (D[w] < min)
                        {
                            v = w;
                            min = D[w];
                        }

                visited[v] = true;

                for (w = 0; w < size; w++)
                    if (!visited[w])
                        if (min + matris[v, w] < D[w])
                            D[w] = min + matris[v, w];

            }
        }

        public ArrayList BFS(int a)
        {
            Queue kuyruk = new Queue();

            bool[,] visited = new bool[size, size];
            ArrayList isimSırası = new ArrayList();

            kuyruk.Enqueue(a);
            visited[0, a] = true;

            for (int k = 0; k < size; k++)
                for (int i = 0; i < size; i++)
                    if (visited[k, i] && kuyruk.Count!=0)
                    {
                        isimSırası.Add(kuyruk.Dequeue());
                        for (int j = k + 1; j < size; j++)
                            for (int n = 0; n < size; n++)
                                if (!visited[j, n] && matris[i, n] != 1000 && n != a)
                                {
                                    kuyruk.Enqueue(n);
                                    for(int y=0;y<size;y++)
                                        visited[y, n] = true;
                                }
                    }
            
            return isimSırası;
        }

        public void MST()
        {
            bool[] visited = new bool[size];
            ArrayList liste = new ArrayList();

            ListeEkle(0, liste, visited);
            visited[0] = true;
            for (int x = 1; x < size; x++)
            {
                if (liste == null || liste.Count==0 || liste[0] == null)
                    continue;
                Edge birYol = (Edge)liste[0];
                liste.RemoveAt(0);

                if (!visited[birYol.dest] && visited[birYol.source] )
                {
                    visited[birYol.dest] = true;
                    ListeEkle(birYol.dest, liste, visited);
                }
                else if (!visited[birYol.source] && visited[birYol.dest])
                {
                    visited[birYol.source] = true;
                    ListeEkle(birYol.source, liste, visited);
                }

                tree[birYol.source, birYol.dest] = 1;
            }
        }
        
        public void ListeEkle(int i,ArrayList liste,bool[] visited)
        {
            int a = 0;
            foreach (Edge birYol in yollar)
                if ((birYol.source == i || birYol.dest == i) && (visited[birYol.source]==false || visited[birYol.dest]==false)) 
                {
                    if (liste.Count == 0)
                        liste.Add(birYol);
                    else
                    {
                        for (int j=0;j<liste.Count;j++)
                        {
                            if (birYol.weight <((Edge)liste[j]).weight)
                            {
                                liste.Insert(a, birYol);
                                break;
                            }
                            a++;
                        }
                        if (i == liste.Count)
                            liste.Add(birYol);
                    }
                }
        }

       
        
    }
}
