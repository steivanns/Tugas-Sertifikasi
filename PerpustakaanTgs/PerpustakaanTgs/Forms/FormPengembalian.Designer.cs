namespace PerpustakaanTgs.Forms
{
    partial class FormPengembalian
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
            cmbPinjam = new ComboBox();
            dtpKembali = new DateTimePicker();
            btnKembalikan = new Button();
            dgvPengembalian = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPengembalian).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPinjam
            // 
            cmbPinjam.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPinjam.FormattingEnabled = true;
            cmbPinjam.Location = new Point(20, 46);
            cmbPinjam.Name = "cmbPinjam";
            cmbPinjam.Size = new Size(307, 31);
            cmbPinjam.TabIndex = 0;
            // 
            // dtpKembali
            // 
            dtpKembali.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpKembali.Location = new Point(22, 116);
            dtpKembali.Name = "dtpKembali";
            dtpKembali.Size = new Size(307, 30);
            dtpKembali.TabIndex = 1;
            // 
            // btnKembalikan
            // 
            btnKembalikan.BackColor = Color.LimeGreen;
            btnKembalikan.FlatStyle = FlatStyle.Popup;
            btnKembalikan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKembalikan.ForeColor = SystemColors.ControlLight;
            btnKembalikan.Location = new Point(115, 329);
            btnKembalikan.Name = "btnKembalikan";
            btnKembalikan.Size = new Size(113, 29);
            btnKembalikan.TabIndex = 3;
            btnKembalikan.Text = "Kembalikan";
            btnKembalikan.UseVisualStyleBackColor = false;
            btnKembalikan.Click += btnKembalikan_Click;
            // 
            // dgvPengembalian
            // 
            dgvPengembalian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPengembalian.Location = new Point(360, 96);
            dgvPengembalian.Name = "dgvPengembalian";
            dgvPengembalian.RowHeadersWidth = 51;
            dgvPengembalian.RowTemplate.Height = 29;
            dgvPengembalian.Size = new Size(610, 390);
            dgvPengembalian.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 79, 216);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 78);
            panel2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(349, 14);
            label5.Name = "label5";
            label5.Size = new Size(247, 46);
            label5.TabIndex = 0;
            label5.Text = "Pengembalian";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnKembalikan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbPinjam);
            panel1.Controls.Add(dtpKembali);
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 390);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(182, 23);
            label2.TabIndex = 10;
            label2.Text = "Tanggal Pengembalian";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 23);
            label1.TabIndex = 9;
            label1.Text = "List Buku Yang Dipinjam";
            // 
            // FormPengembalian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 498);
            Controls.Add(panel2);
            Controls.Add(dgvPengembalian);
            Controls.Add(panel1);
            Name = "FormPengembalian";
            Text = "FormPengembalian";
            Load += FormPengembalian_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPengembalian).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPinjam;
        private DateTimePicker dtpKembali;
        private Button btnKembalikan;
        private DataGridView dgvPengembalian;
        private Panel panel2;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}