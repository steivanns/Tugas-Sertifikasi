namespace PerpustakaanTgs.Forms
{
    partial class FormAnggota
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
            txtNama = new TextBox();
            txtAlamat = new TextBox();
            txtNoHp = new TextBox();
            btnTambah = new Button();
            btnUbah = new Button();
            btnHapus = new Button();
            btnReset = new Button();
            dgvAnggota = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnggota).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(20, 51);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(242, 27);
            txtNama.TabIndex = 0;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(20, 121);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(242, 27);
            txtAlamat.TabIndex = 1;
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(20, 191);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(240, 27);
            txtNoHp.TabIndex = 2;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.LimeGreen;
            btnTambah.FlatStyle = FlatStyle.Popup;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = SystemColors.ControlLight;
            btnTambah.Location = new Point(42, 295);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 3;
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
            btnUbah.Location = new Point(154, 330);
            btnUbah.Name = "btnUbah";
            btnUbah.Size = new Size(94, 29);
            btnUbah.TabIndex = 4;
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
            btnHapus.Location = new Point(154, 295);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 5;
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
            btnReset.Location = new Point(42, 330);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvAnggota
            // 
            dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnggota.Location = new Point(321, 96);
            dgvAnggota.Name = "dgvAnggota";
            dgvAnggota.RowHeadersWidth = 51;
            dgvAnggota.RowTemplate.Height = 29;
            dgvAnggota.Size = new Size(649, 390);
            dgvAnggota.TabIndex = 7;
            dgvAnggota.CellClick += dgvAnggota_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 167, 132);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 78);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(390, 13);
            label5.Name = "label5";
            label5.Size = new Size(169, 50);
            label5.TabIndex = 0;
            label5.Text = "Member";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNoHp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(btnUbah);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(txtNama);
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 390);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 12;
            label4.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 11;
            label3.Text = "No HP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 90);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 10;
            label1.Text = "Alamat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 9;
            // 
            // FormAnggota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 498);
            Controls.Add(panel2);
            Controls.Add(dgvAnggota);
            Controls.Add(panel1);
            Name = "FormAnggota";
            Text = "FormAnggota";
            Load += FormAnggota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnggota).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNama;
        private TextBox txtAlamat;
        private TextBox txtNoHp;
        private Button btnTambah;
        private Button btnUbah;
        private Button btnHapus;
        private Button btnReset;
        private DataGridView dgvAnggota;
        private Panel panel2;
        private Label label5;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}