using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Project
{
   public  class SocialNetwork
    {
        public List<SocialEdge> Edges;
        public int[,] Matris;
        public Person[] Verticles;
        public int Size { get; set; }

        public SocialNetwork(int size)
        {
            this.Size = size;
            InitializeComponent();

        }

        public void InitializeComponent()
        {
            Matris = new int[Size,Size];
            Edges = new List<SocialEdge>();
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    Matris[i, j] = 1000;

            Verticles = new Person[Size];
            for (int i = 0; i < Size; i++)
                Verticles[i] = null;
            
        }

        public void Add(Person source, Person dest,int weight)
        {
            

            Matris[source.Value, dest.Value] = weight;
            Matris[dest.Value, source.Value] = weight;
            VerticleAdd(source);
            VerticleAdd(dest);

            SocialEdge edge = new SocialEdge(source, dest, weight);
            Edges.Add(edge);
        }

        private void VerticleAdd(Person person)
        {
            bool has = false;
            for (int i = 0; i < Size; i++)
            {
                if (Verticles[i] == null)
                    continue;
                if (Verticles[i].Value == person.Value)
                    has = true;
            }
            if(!has)
            {
                Verticles[person.Value] = person;
            }
        }

        private List<Person> BFS(int a)
        {
            Queue kuyruk = new Queue();

            bool[,] visited = new bool[Size, Size];
            List<Person> isimSırası = new List<Person>();

            kuyruk.Enqueue(a);
            visited[0, a] = true;

            for (int k = 0; k < Size; k++)
                for (int i = 0; i < Size; i++)
                    if (visited[k, i] && kuyruk.Count != 0)
                    {
                        isimSırası.Add(Verticles[(int)kuyruk.Dequeue()]);
                        for (int j = k + 1; j < Size; j++)
                            for (int n = 0; n < Size; n++)
                                if (!visited[j, n] && Matris[i, n] != 1000 && n != a)
                                {
                                    kuyruk.Enqueue(n);
                                    for (int y = 0; y < Size; y++)
                                        visited[y, n] = true;
                                }
                    }

            return isimSırası;
        }

        public List<Person> BFS(string isim)
        {
            int index = -1;
            List<Person> list;
            for (int i = 0; i < Size; i++)
                if (Verticles[i].Name.Equals(isim))
                    index = Verticles[i].Value;

            if (index == -1)
                return null;

            list = BFS(index);
            return list;
        }

        
        
    }
}
