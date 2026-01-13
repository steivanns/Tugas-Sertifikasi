namespace PerpustakaanTgs.Forms
{
    partial class FormPeminjamanAnggota
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
            panel1 = new Panel();
            label1 = new Label();
            dgvPeminjaman = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            lblJatuhTempo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbAnggota = new ComboBox();
            cmbBuku = new ComboBox();
            dtpPinjam = new DateTimePicker();
            btnPinjam = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjaman).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 167, 132);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 78);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(365, 15);
            label1.Name = "label1";
            label1.Size = new Size(238, 50);
            label1.TabIndex = 0;
            label1.Text = "Peminjaman";
            // 
            // dgvPeminjaman
            // 
            dgvPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeminjaman.Location = new Point(418, 96);
            dgvPeminjaman.Name = "dgvPeminjaman";
            dgvPeminjaman.RowHeadersWidth = 51;
            dgvPeminjaman.RowTemplate.Height = 29;
            dgvPeminjaman.Size = new Size(552, 390);
            dgvPeminjaman.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblJatuhTempo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbAnggota);
            panel2.Controls.Add(cmbBuku);
            panel2.Controls.Add(dtpPinjam);
            panel2.Controls.Add(btnPinjam);
            panel2.Location = new Point(12, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 390);
            panel2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 230);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 10;
            label6.Text = "Jatuh Tempo";
            // 
            // lblJatuhTempo
            // 
            lblJatuhTempo.AutoSize = true;
            lblJatuhTempo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblJatuhTempo.Location = new Point(20, 253);
            lblJatuhTempo.Name = "lblJatuhTempo";
            lblJatuhTempo.Size = new Size(107, 23);
            lblJatuhTempo.TabIndex = 9;
            lblJatuhTempo.Text = "Jatuh Tempo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 160);
            label5.Name = "label5";
            label5.Size = new Size(168, 23);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Peminjaman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 90);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 7;
            label4.Text = "Nama Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 94);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // cmbAnggota
            // 
            cmbAnggota.FormattingEnabled = true;
            cmbAnggota.Location = new Point(20, 46);
            cmbAnggota.Name = "cmbAnggota";
            cmbAnggota.Size = new Size(358, 28);
            cmbAnggota.TabIndex = 0;
            // 
            // cmbBuku
            // 
            cmbBuku.FormattingEnabled = true;
            cmbBuku.Location = new Point(20, 116);
            cmbBuku.Name = "cmbBuku";
            cmbBuku.Size = new Size(362, 28);
            cmbBuku.TabIndex = 1;
            // 
            // dtpPinjam
            // 
            dtpPinjam.Location = new Point(20, 186);
            dtpPinjam.Name = "dtpPinjam";
            dtpPinjam.Size = new Size(250, 27);
            dtpPinjam.TabIndex = 2;
            dtpPinjam.ValueChanged += dtpPinjam_ValueChanged;

            // 
            // btnPinjam
            // 
            btnPinjam.BackColor = Color.LimeGreen;
            btnPinjam.FlatStyle = FlatStyle.Popup;
            btnPinjam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPinjam.ForeColor = SystemColors.ControlLight;
            btnPinjam.Location = new Point(155, 341);
            btnPinjam.Name = "btnPinjam";
            btnPinjam.Size = new Size(94, 29);
            btnPinjam.TabIndex = 4;
            btnPinjam.Text = "Pinjam";
            btnPinjam.UseVisualStyleBackColor = false;
            btnPinjam.Click += btnPinjam_Click;
            // 
            // FormPeminjamanAnggota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 498);
            Controls.Add(panel1);
            Controls.Add(dgvPeminjaman);
            Controls.Add(panel2);
            Name = "FormPeminjamanAnggota";
            Text = "FormPeminjamanAnggota";
            Load += FormPeminjamanAnggota_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeminjaman).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvPeminjaman;
        private Panel panel2;
        private Label label6;
        private Label lblJatuhTempo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbAnggota;
        private ComboBox cmbBuku;
        private DateTimePicker dtpPinjam;
        private Button btnPinjam;
    }
}