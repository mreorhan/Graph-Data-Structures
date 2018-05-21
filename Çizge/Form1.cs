using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çizge
{
    public partial class Form1 : Form
    {
        int size;
        public Graph birGraph;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            size = int.Parse(textBox1.Text);
            birGraph = new Graph(size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            birGraph.ekle(int.Parse(textBox2.Text) - 1, int.Parse(textBox3.Text) - 1, int.Parse(textBox4.Text));

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void But_SP_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, uzaklık;

            a = int.Parse(textBox7.Text);
            b = int.Parse(textBox6.Text);

            uzaklık = birGraph.Dijktras(a - 1, b - 1);

            if (uzaklık != 1000)
                MessageBox.Show("Köşe çifti arasındaki en kısa uzaklık: " + uzaklık);
            else
                MessageBox.Show("Köşe çifti arasında bir yol yok!! ");

            textBox7.Clear();
            textBox6.Clear();
            groupBox4.Visible = false;
        }

        private void But_BFS_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            ArrayList isimSırası = new ArrayList();

            listBox1.Items.Clear();

            x = int.Parse(textBox5.Text);

            isimSırası = birGraph.BFS(x - 1);

            listBox1.Visible = true;

            foreach (int i in isimSırası)
                listBox1.Items.Add((i + 1) + "\n");

            textBox3.Clear();
        }

        private void But_MST_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

            birGraph.MST();

            Form3 frm3 = new Form3(birGraph);
            frm3.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;

            Form2 frm2 = new Form2(birGraph);
            frm2.Show();           
        }
    }
}
