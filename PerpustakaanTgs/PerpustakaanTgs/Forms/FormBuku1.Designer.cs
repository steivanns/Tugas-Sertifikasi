namespace PerpustakaanTgs.Forms
{
    partial class FormBuku1
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
            txtJudul = new TextBox();
            txtPenulis = new TextBox();
            numTahun = new NumericUpDown();
            numStok = new NumericUpDown();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            dgvBuku = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTahun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtJudul
            // 
            txtJudul.Location = new Point(20, 111);
            txtJudul.Name = "txtJudul";
            txtJudul.Size = new Size(262, 27);
            txtJudul.TabIndex = 0;
            txtJudul.TextChanged += txtJudul_TextChanged;
            // 
            // txtPenulis
            // 
            txtPenulis.Location = new Point(20, 46);
            txtPenulis.Name = "txtPenulis";
            txtPenulis.Size = new Size(262, 27);
            txtPenulis.TabIndex = 1;
            txtPenulis.TextChanged += txtPenulis_TextChanged;
            // 
            // numTahun
            // 
            numTahun.Location = new Point(182, 186);
            numTahun.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numTahun.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numTahun.Name = "numTahun";
            numTahun.Size = new Size(100, 27);
            numTahun.TabIndex = 2;
            numTahun.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            numTahun.ValueChanged += numTahun_ValueChanged;
            // 
            // numStok
            // 
            numStok.Location = new Point(20, 186);
            numStok.Name = "numStok";
            numStok.Size = new Size(100, 27);
            numStok.TabIndex = 3;
            numStok.ValueChanged += numStok_ValueChanged;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.LimeGreen;
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLight;
            btnTambah.Location = new Point(39, 291);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnUbah
            // 
            btnUbah.BackColor = SystemColors.MenuHighlight;
            btnUbah.FlatStyle = FlatStyle.Popup;
            btnUbah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUbah.ForeColor = SystemColors.ControlLight;
            btnUbah.Location = new Point(172, 335);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(94, 29);
            btnUbah.TabIndex = 5;
            btnUbah.Text = "Ubah";
            btnUbah.UseVisualStyleBackColor = false;
            btnUbah.Click += btnUbah_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.FlatStyle = FlatStyle.Popup;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHapus.ForeColor = SystemColors.ControlLight;
            btnHapus.Location = new Point(172, 291);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 6;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.DarkGray;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ControlLight;
            btnReset.Location = new Point(39, 335);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvBuku
            // 
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Location = new Point(3, 3);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.RowHeadersWidth = 51;
            dgvBuku.RowTemplate.Height = 29;
            dgvBuku.Size = new Size(645, 386);
            dgvBuku.TabIndex = 8;
            dgvBuku.CellClick += dgvBuku_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBuku);
            panel1.Location = new Point(325, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 392);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 79, 216);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 78);
            panel2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(427, 14);
            label5.Name = "label5";
            label5.Size = new Size(111, 50);
            label5.TabIndex = 0;
            label5.Text = "Buku";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnUbah);
            panel3.Controls.Add(btnHapus);
            panel3.Controls.Add(numStok);
            panel3.Controls.Add(btnTambah);
            panel3.Controls.Add(txtPenulis);
            panel3.Controls.Add(numTahun);
            panel3.Controls.Add(txtJudul);
            panel3.Controls.Add(btnReset);
            panel3.Location = new Point(12, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 389);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(183, 160);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 11;
            label4.Text = "Tahun Buku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 10;
            label3.Text = "Stock Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 85);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 9;
            label2.Text = "Judul Buku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 8;
            label1.Text = "Penulis";
            label1.Click += label1_Click;
            // 
            // FormBuku1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(982, 498);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FormBuku1";
            Text = "Form Buku";
            Load += FormBuku1_Load;
            ((System.ComponentModel.ISupportInitialize)numTahun).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtJudul;
        private TextBox txtPenulis;
        private NumericUpDown numTahun;
        private NumericUpDown numStok;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnReset;
        private DataGridView dgvBuku;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}