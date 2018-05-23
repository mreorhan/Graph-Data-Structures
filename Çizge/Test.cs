using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Project
{
    public class Test
    {
        public Graph graph { get; set; }
        public SocialNetwork social { get; set; }

        public Test()
        {

        }

        public void TestEkleGraph()
        {
            graph = new Graph(7);
            graph.Ekle(0, 1, 5);
            graph.Ekle(0, 2, 7);
            graph.Ekle(0, 4, 6);
            graph.Ekle(4, 5, 2);
            graph.Ekle(1, 3, 8);
            graph.Ekle(3, 6, 2);
            graph.Ekle(6, 4, 5);
            graph.Ekle(0, 6, 7);
            graph.Ekle(3, 2, 1);
            graph.Ekle(1, 6, 4);

        }

        public void TestEkleSocialNetwork()
        {
            social = new SocialNetwork(6);
            Person olivia = new Person
            {
                Name = "Olivia",
                Job = "Doktor",
                Value = 0
            };

            Person celine = new Person
            {
                Name = "Celine",
                Job = "Mühendis",
                Value = 1
            };

            Person john = new Person
            {
                Name = "John",
                Job = "Subay",
                Value = 2
            };

            Person jack = new Person
            {
                Name = "Jack",
                Job = "Profesör",
                Value = 3
            };

            Person chloe = new Person
            {
                Name = "Chloe",
                Job = "Mimar",
                Value = 4
            };

            Person winston = new Person
            {
                Name = "Winston",
                Job = "Politikacı",
                Value = 5
            };


            social.Add(olivia, celine, 5);
            social.Add(olivia, john, 12);
            social.Add(olivia, jack, 8);
            social.Add(celine, jack, 6);
            social.Add(celine,winston,10);  
            social.Add(chloe, winston, 15);
            social.Add(chloe, jack, 4);
            social.Add(chloe, john, 9);
            social.Add(jack, winston, 16);
            social.Add(jack, john, 7);

        }


    }
}
