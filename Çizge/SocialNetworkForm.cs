using System;
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
    public partial class SocialNetworkForm : Form
    {

        SocialNetwork social;
        public SocialNetworkForm(SocialNetwork social)
        {
            this.social = social;
            InitializeComponent();
        }

        private void SocialNetworkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSocialNetwork_Click(object sender, EventArgs e)
        {
            Person[] people = social.Verticles;

            string str = "";
            for (int i = 0; i < people.Length; i++)
            {
                str += String.Format("İsim: {0} İş: {1} Değer: {2}", people[i].Name, people[i].Job, people[i].Value + Environment.NewLine);
            }

            MessageBox.Show(str);
        }

        private void But_BFS_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnBFSEkle_Click(object sender, EventArgs e)
        {
            string isim = txtBFSEkle.Text;

            List<Person> peopleBFS = social.BFS(isim);
            if (peopleBFS == null)
            {
                MessageBox.Show("Bu isim sosyal ağda bulunmamaktadır");
                return;
            }

            string str = "";
            for (int i = 0; i < peopleBFS.Count; i++)
            {
                str += String.Format("İsim: {0} İş: {1} Değer: {2}", peopleBFS[i].Name, peopleBFS[i].Job, peopleBFS[i].Value + Environment.NewLine);
            }

            MessageBox.Show(str);
        }

        private void btnMenuCizgeCizdirme_Click(object sender, EventArgs e)
        {
            var p = panel1;
            var g = panel1.CreateGraphics();

            float a = 0, b = 0, a2, b2;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.Show();
            SolidBrush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(Color.Salmon, 2);

            Person[] people = social.Verticles;



            for (int i = 0; i < social.Size; i++)
            {

                string str = "";

                str += String.Format("İsim: {0}{3}İş: {1}{3}Değer: {2}", people[i].Name, people[i].Job, people[i].Value, Environment.NewLine);


                a = (float)Math.Cos(i * (360 / social.Size));
                b = (float)Math.Sin(i * (360 / social.Size));
                g.DrawString(str, new Font("Segoe UI", 8), b1, (100 * a + 100 + 13), (100 * b + 100 + 10));
                g.DrawEllipse(p1, (100 * a + 100), (100 * b + 100), 40, 40);
                for (int j = 0; j < social.Size; j++)
                {
                    if (social.Matris[i, j] != 1000)
                    {
                        a2 = (float)Math.Cos(j * (360 / social.Size));
                        b2 = (float)Math.Sin(j * (360 / social.Size));
                        g.DrawLine(p1, (90 * a + 115), (90 * b + 115), (90 * a2 + 115), (90 * b2 + 115));
                    }
                }
            }
        }
    }
}
