using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çizge
{
    class Edge
    {
        public int source;
        public int dest;
        public int weight;

        public Edge(int v1,int v2,int e)
        {
            this.source = v1;
            this.dest = v2;
            this.weight = e;
        }

        public int compareTo(Edge compareEdge)
        {
            return this.weight - compareEdge.weight;
        }
    }
}
