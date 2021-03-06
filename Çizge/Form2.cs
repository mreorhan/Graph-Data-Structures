﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Project
{
    public partial class Form2 : Form
    {
        Graph birGraph;
        public Form2(Graph birGraph)
        {
            this.birGraph = birGraph;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {  
                
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            float a = 0, b = 0, a2, b2;
           
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.Show();
            SolidBrush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(Color.Salmon, 2);

            for (int i = 0; i < birGraph.size; i++)
            {
                a = (float)Math.Cos(i * (360 / birGraph.size));
                b = (float)Math.Sin(i * (360 / birGraph.size));
                g.DrawString("" + (i + 1), new Font("Segoe UI", 12), b1, (100 * a + 100+13), (100 * b + 100+10));
                g.DrawEllipse(p1, (100 * a + 100), (100 * b + 100), 40, 40);
                for (int j = 0; j < birGraph.size; j++)
                {
                    if (birGraph.matris[i, j] != 1000)
                    {
                        a2 = (float)Math.Cos(j * (360 / birGraph.size));
                        b2 = (float)Math.Sin(j * (360 / birGraph.size));
                        g.DrawLine(p1, (90 * a + 115), (90 * b + 115), (90 * a2 + 115), (90 * b2 + 115));
                        
                    }
                }
            }


        }
    }
}
