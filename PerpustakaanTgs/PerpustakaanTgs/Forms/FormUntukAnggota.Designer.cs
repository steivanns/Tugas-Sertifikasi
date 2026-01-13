namespace PerpustakaanTgs.Forms
{
    partial class FormUntukAnggota
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
            panelHeader = new Panel();
            lblJudul = new Label();
            lblTanggal = new Label();
            panelKembali = new Panel();
            picKembali = new PictureBox();
            lblKembali = new Label();
            panelPinjam = new Panel();
            picPinjam = new PictureBox();
            lblMember = new Label();
            panelHeader.SuspendLayout();
            panelKembali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKembali).BeginInit();
            panelPinjam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPinjam).BeginInit();
            SuspendLayout();
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
            panelHeader.TabIndex = 5;
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblJudul.Location = new Point(269, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(236, 54);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Perpustakaan";
            // lblJudul.Click += lblJudul_Click;
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
            // panelKembali
            // 
            panelKembali.BackColor = Color.FromArgb(31, 79, 216);
            panelKembali.Controls.Add(picKembali);
            panelKembali.Controls.Add(lblKembali);
            panelKembali.Cursor = Cursors.Hand;
            panelKembali.Location = new Point(420, 186);
            panelKembali.Name = "panelKembali";
            panelKembali.Size = new Size(200, 120);
            panelKembali.TabIndex = 6;
            panelKembali.Click += PanelKembali_Click;
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
            picKembali.Click += PicKembali_Click;
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
            lblKembali.Text = "Peminjaman Buku";
            lblKembali.TextAlign = ContentAlignment.MiddleCenter;
            lblKembali.Click += LblKembali_Click;
            // 
            // panelPinjam
            // 
            panelPinjam.BackColor = Color.FromArgb(27, 167, 132);
            panelPinjam.Controls.Add(picPinjam);
            panelPinjam.Controls.Add(lblMember);
            panelPinjam.Cursor = Cursors.Hand;
            panelPinjam.Location = new Point(180, 186);
            panelPinjam.Name = "panelPinjam";
            panelPinjam.Size = new Size(200, 120);
            panelPinjam.TabIndex = 7;
            panelPinjam.Click += PanelPinjam_Click;
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
            picPinjam.Click += PicPinjam_Click;
            // 
            // lblMember
            // 
            lblMember.Dock = DockStyle.Bottom;
            lblMember.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMember.ForeColor = Color.White;
            lblMember.Location = new Point(0, 90);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(200, 30);
            lblMember.TabIndex = 1;
            lblMember.Text = "Anggota";
            lblMember.TextAlign = ContentAlignment.MiddleCenter;
            lblMember.Click += LblMember_Click;
            // 
            // FormUntukAnggota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelKembali);
            Controls.Add(panelPinjam);
            Controls.Add(panelHeader);
            Name = "FormUntukAnggota";
            Text = "FormUntukAnggota";
            Load += FormUntukAnggota_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelKembali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picKembali).EndInit();
            panelPinjam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPinjam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblJudul;
        private Label lblTanggal;
        private Panel panelKembali;
        private PictureBox picKembali;
        private Label lblKembali;
        private Panel panelPinjam;
        private PictureBox picPinjam;
        private Label lblMember;
    }
}