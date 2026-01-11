namespace PerpustakaanTgs.Forms
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelBuku = new Panel();
            picBuku = new PictureBox();
            lblBuku = new Label();
            panelAnggota = new Panel();
            picAnggota = new PictureBox();
            lblAnggota = new Label();
            panelPinjam = new Panel();
            picPinjam = new PictureBox();
            lblPinjam = new Label();
            panelKembali = new Panel();
            picKembali = new PictureBox();
            lblKembali = new Label();
            lblTanggal = new Label();
            lblJudul = new Label();
            panelHeader = new Panel();
            panelBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBuku).BeginInit();
            panelAnggota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnggota).BeginInit();
            panelPinjam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinjam).BeginInit();
            panelKembali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKembali).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelBuku
            // 
            panelBuku.BackColor = Color.FromArgb(31, 79, 216);
            panelBuku.Controls.Add(picBuku);
            panelBuku.Controls.Add(lblBuku);
            panelBuku.Cursor = Cursors.Hand;
            panelBuku.Location = new Point(221, 127);
            panelBuku.Name = "panelBuku";
            panelBuku.Size = new Size(200, 120);
            panelBuku.TabIndex = 3;
            panelBuku.Click += panelBuku_Click;
            // 
            // picBuku
            // 
            picBuku.Dock = DockStyle.Fill;
            picBuku.Location = new Point(0, 0);
            picBuku.Name = "picBuku";
            picBuku.Size = new Size(200, 90);
            picBuku.SizeMode = PictureBoxSizeMode.Zoom;
            picBuku.TabIndex = 0;
            picBuku.TabStop = false;
            picBuku.Click += panelBuku_Click;
            // 
            // lblBuku
            // 
            lblBuku.Dock = DockStyle.Bottom;
            lblBuku.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuku.ForeColor = Color.White;
            lblBuku.Location = new Point(0, 90);
            lblBuku.Name = "lblBuku";
            lblBuku.Size = new Size(200, 30);
            lblBuku.TabIndex = 1;
            lblBuku.Text = "Penambahan Buku";
            lblBuku.TextAlign = ContentAlignment.MiddleCenter;
            lblBuku.Click += panelBuku_Click;
            // 
            // panelAnggota
            // 
            panelAnggota.BackColor = Color.FromArgb(27, 167, 132);
            panelAnggota.Controls.Add(picAnggota);
            panelAnggota.Controls.Add(lblAnggota);
            panelAnggota.Cursor = Cursors.Hand;
            panelAnggota.Location = new Point(461, 127);
            panelAnggota.Name = "panelAnggota";
            panelAnggota.Size = new Size(200, 120);
            panelAnggota.TabIndex = 2;
            panelAnggota.Click += panelAnggota_Click;
            // 
            // picAnggota
            // 
            picAnggota.Dock = DockStyle.Fill;
            picAnggota.Location = new Point(0, 0);
            picAnggota.Name = "picAnggota";
            picAnggota.Size = new Size(200, 90);
            picAnggota.SizeMode = PictureBoxSizeMode.Zoom;
            picAnggota.TabIndex = 0;
            picAnggota.TabStop = false;
            picAnggota.Click += panelAnggota_Click;
            // 
            // lblAnggota
            // 
            lblAnggota.Dock = DockStyle.Bottom;
            lblAnggota.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnggota.ForeColor = Color.White;
            lblAnggota.Location = new Point(0, 90);
            lblAnggota.Name = "lblAnggota";
            lblAnggota.Size = new Size(200, 30);
            lblAnggota.TabIndex = 1;
            lblAnggota.Text = "Profil Member";
            lblAnggota.TextAlign = ContentAlignment.MiddleCenter;
            lblAnggota.Click += panelAnggota_Click;
            // 
            // panelPinjam
            // 
            panelPinjam.BackColor = Color.FromArgb(27, 167, 132);
            panelPinjam.Controls.Add(picPinjam);
            panelPinjam.Controls.Add(lblPinjam);
            panelPinjam.Cursor = Cursors.Hand;
            panelPinjam.Location = new Point(221, 277);
            panelPinjam.Name = "panelPinjam";
            panelPinjam.Size = new Size(200, 120);
            panelPinjam.TabIndex = 1;
            panelPinjam.Click += panelPinjam_Click;
            // 
            // picPinjam
            // 
            picPinjam.Dock = DockStyle.Fill;
            picPinjam.Location = new Point(0, 0);
            picPinjam.Name = "picPinjam";
            picPinjam.Size = new Size(200, 90);
            picPinjam.SizeMode = PictureBoxSizeMode.Zoom;
            picPinjam.TabIndex = 0;
            picPinjam.TabStop = false;
            picPinjam.Click += panelPinjam_Click;
            // 
            // lblPinjam
            // 
            lblPinjam.Dock = DockStyle.Bottom;
            lblPinjam.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPinjam.ForeColor = Color.White;
            lblPinjam.Location = new Point(0, 90);
            lblPinjam.Name = "lblPinjam";
            lblPinjam.Size = new Size(200, 30);
            lblPinjam.TabIndex = 1;
            lblPinjam.Text = "Pinjam Buku";
            lblPinjam.TextAlign = ContentAlignment.MiddleCenter;
            lblPinjam.Click += panelPinjam_Click;
            // 
            // panelKembali
            // 
            panelKembali.BackColor = Color.FromArgb(31, 79, 216);
            panelKembali.Controls.Add(picKembali);
            panelKembali.Controls.Add(lblKembali);
            panelKembali.Cursor = Cursors.Hand;
            panelKembali.Location = new Point(461, 277);
            panelKembali.Name = "panelKembali";
            panelKembali.Size = new Size(200, 120);
            panelKembali.TabIndex = 0;
            panelKembali.Click += panelKembali_Click;
            // 
            // picKembali
            // 
            picKembali.Dock = DockStyle.Fill;
            picKembali.Location = new Point(0, 0);
            picKembali.Name = "picKembali";
            picKembali.Size = new Size(200, 90);
            picKembali.SizeMode = PictureBoxSizeMode.Zoom;
            picKembali.TabIndex = 0;
            picKembali.TabStop = false;
            picKembali.Click += panelKembali_Click;
            // 
            // lblKembali
            // 
            lblKembali.Dock = DockStyle.Bottom;
            lblKembali.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblKembali.ForeColor = Color.White;
            lblKembali.Location = new Point(0, 90);
            lblKembali.Name = "lblKembali";
            lblKembali.Size = new Size(200, 30);
            lblKembali.TabIndex = 1;
            lblKembali.Text = "Kembalikan";
            lblKembali.TextAlign = ContentAlignment.MiddleCenter;
            lblKembali.Click += panelKembali_Click;
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
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblJudul.Location = new Point(313, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(236, 54);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Perpustakaan";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Controls.Add(lblTanggal);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(900, 73);
            panelHeader.TabIndex = 4;
            // 
            // FormMain
            // 
            ClientSize = new Size(900, 500);
            Controls.Add(panelKembali);
            Controls.Add(panelPinjam);
            Controls.Add(panelAnggota);
            Controls.Add(panelBuku);
            Controls.Add(panelHeader);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMain_Load;
            panelBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBuku).EndInit();
            panelAnggota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAnggota).EndInit();
            panelPinjam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPinjam).EndInit();
            panelKembali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picKembali).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBuku;
        private PictureBox picBuku;
        private Label lblBuku;

        private Panel panelAnggota;
        private PictureBox picAnggota;
        private Label lblAnggota;

        private Panel panelPinjam;
        private PictureBox picPinjam;
        private Label lblPinjam;

        private Panel panelKembali;
        private PictureBox picKembali;
        private Label lblKembali;
        private Label lblTanggal;
        private Label lblJudul;
        private Panel panelHeader;
    }
}
