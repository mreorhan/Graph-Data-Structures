namespace Graph_Project
{
    partial class SocialNetworkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSocialNetwork = new System.Windows.Forms.Button();
            this.But_BFS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBFSEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBFSEkle = new System.Windows.Forms.Button();
            this.btnMenuCizgeCizdirme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.But_SP = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.But_SP);
            this.groupBox5.Controls.Add(this.btnMenuCizgeCizdirme);
            this.groupBox5.Controls.Add(this.btnSocialNetwork);
            this.groupBox5.Controls.Add(this.But_BFS);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 177);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MENÜ";
            // 
            // btnSocialNetwork
            // 
            this.btnSocialNetwork.Location = new System.Drawing.Point(29, 98);
            this.btnSocialNetwork.Name = "btnSocialNetwork";
            this.btnSocialNetwork.Size = new System.Drawing.Size(143, 28);
            this.btnSocialNetwork.TabIndex = 44;
            this.btnSocialNetwork.Text = "Sosyal Ağ";
            this.btnSocialNetwork.UseVisualStyleBackColor = true;
            this.btnSocialNetwork.Click += new System.EventHandler(this.btnSocialNetwork_Click);
            // 
            // But_BFS
            // 
            this.But_BFS.Location = new System.Drawing.Point(29, 26);
            this.But_BFS.Name = "But_BFS";
            this.But_BFS.Size = new System.Drawing.Size(143, 30);
            this.But_BFS.TabIndex = 35;
            this.But_BFS.Text = "Breadth First Traverse";
            this.But_BFS.UseVisualStyleBackColor = true;
            this.But_BFS.Click += new System.EventHandler(this.But_BFS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBFSEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBFSEkle);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 56);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BFS";
            this.groupBox1.Visible = false;
            // 
            // txtBFSEkle
            // 
            this.txtBFSEkle.Location = new System.Drawing.Point(47, 19);
            this.txtBFSEkle.Name = "txtBFSEkle";
            this.txtBFSEkle.Size = new System.Drawing.Size(100, 20);
            this.txtBFSEkle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // btnBFSEkle
            // 
            this.btnBFSEkle.Location = new System.Drawing.Point(160, 17);
            this.btnBFSEkle.Name = "btnBFSEkle";
            this.btnBFSEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBFSEkle.TabIndex = 2;
            this.btnBFSEkle.Text = "ENTER";
            this.btnBFSEkle.UseVisualStyleBackColor = true;
            this.btnBFSEkle.Click += new System.EventHandler(this.btnBFSEkle_Click);
            // 
            // btnMenuCizgeCizdirme
            // 
            this.btnMenuCizgeCizdirme.Location = new System.Drawing.Point(29, 132);
            this.btnMenuCizgeCizdirme.Name = "btnMenuCizgeCizdirme";
            this.btnMenuCizgeCizdirme.Size = new System.Drawing.Size(143, 28);
            this.btnMenuCizgeCizdirme.TabIndex = 45;
            this.btnMenuCizgeCizdirme.Text = "Çizge Çizdirme";
            this.btnMenuCizgeCizdirme.UseVisualStyleBackColor = true;
            this.btnMenuCizgeCizdirme.Click += new System.EventHandler(this.btnMenuCizgeCizdirme_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(218, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 278);
            this.panel1.TabIndex = 43;
            // 
            // But_SP
            // 
            this.But_SP.Location = new System.Drawing.Point(29, 62);
            this.But_SP.Name = "But_SP";
            this.But_SP.Size = new System.Drawing.Size(143, 30);
            this.But_SP.TabIndex = 46;
            this.But_SP.Text = "Dikjtra\'s Shortest Path";
            this.But_SP.UseVisualStyleBackColor = true;
            // 
            // SocialNetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "SocialNetworkForm";
            this.Text = "SocialNetworkForm";
            this.Load += new System.EventHandler(this.SocialNetworkForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSocialNetwork;
        private System.Windows.Forms.Button But_BFS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBFSEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBFSEkle;
        private System.Windows.Forms.Button btnMenuCizgeCizdirme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button But_SP;
    }
}