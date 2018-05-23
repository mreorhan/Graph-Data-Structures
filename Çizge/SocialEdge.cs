using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Project
{
   public  class SocialEdge
    {
        public Person Source { get; set; }
        public Person Destination { get; set; }
        public int Weight { get; set; }

        public SocialEdge(Person source, Person dest, int weight)
        {
            this.Source = source;
            this.Destination = dest;
            this.Weight = weight;
        }

        public int CompareTo(SocialEdge compareEdge)
        {
            return this.Weight - compareEdge.Weight;
        }
    }
}
