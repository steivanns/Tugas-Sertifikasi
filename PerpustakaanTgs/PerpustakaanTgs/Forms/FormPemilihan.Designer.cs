namespace PerpustakaanTgs.Forms
{
    partial class FormPemilihan
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
            panelBuku = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panelHeader = new Panel();
            lblJudul = new Label();
            lblTanggal = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelBuku
            // 
            panelBuku.BackColor = Color.FromArgb(31, 79, 216);
            panelBuku.Cursor = Cursors.Hand;
            panelBuku.Location = new Point(180, 165);
            panelBuku.Name = "panelBuku";
            panelBuku.Size = new Size(200, 120);
            panelBuku.TabIndex = 5;
            panelBuku.Click += PanelBuku_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(69, 7);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 6;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 79, 216);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(180, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 32);
            panel1.TabIndex = 0;
            panel1.Click += Panel1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 167, 132);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(420, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 32);
            panel2.TabIndex = 7;
            panel2.Click += Panel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(62, 6);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 6;
            label2.Text = "Anggota";
            label2.Click += Label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(27, 167, 132);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(420, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 120);
            panel3.TabIndex = 8;
            panel3.Click += Panel3_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Controls.Add(lblTanggal);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 73);
            panelHeader.TabIndex = 9;
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblJudul.Location = new Point(263, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(272, 54);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Pemilihan User";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTanggal.Location = new Point(750, 20);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(0, 20);
            lblTanggal.TabIndex = 1;
            // 
            // FormPemilihan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelHeader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panelBuku);
            Name = "FormPemilihan";
            Text = "FormPemilihan";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private Panel panelBuku;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panelHeader;
        private Label lblJudul;
        private Label lblTanggal;
    }
}