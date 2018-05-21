using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çizge
{
    public partial class Form3 : Form
    {
        Graph birGraph;
        public Form3(Graph birGraph)
        {
            this.birGraph = birGraph;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            float a = 0, b = 0, a2, b2;
            Graphics g = this.CreateGraphics();
            this.Show();
            SolidBrush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(Color.Black, 1);

            for (float i = 0; i < birGraph.size; i++)
            {
                a = (float)Math.Cos(i * (360 / birGraph.size));
                b = (float)Math.Sin(i * (360 / birGraph.size));
                g.DrawString("" + (i + 1), new Font("Times New Roman", 10), b1, (50 * a + 104), (50 * b + 104));
                g.DrawEllipse(p1, (50 * a + 100), (50 * b + 100), 20, 20);
                for (int j = 0; j < birGraph.size; j++)
                {
                    if (birGraph.tree[(int)i, j] == 1)
                    {
                        a2 = (float)Math.Cos(j * (360 / birGraph.size));
                        b2 = (float)Math.Sin(j * (360 / birGraph.size));
                        g.DrawLine(p1, (45 * a + 107), (45 * b + 115), (45 * a2 + 107), (45 * b2 + 115));
                    }
                }
            }
        }
    }
}
