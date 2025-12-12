namespace junpro_pradana
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpDataDeveloper;
        private System.Windows.Forms.Label lblNamaDev;
        private System.Windows.Forms.Label lblIdProyek;
        private System.Windows.Forms.Label lblStatusKontrak;
        private System.Windows.Forms.Label lblFturSelesai;
        private System.Windows.Forms.Label lblJumlahBug;
        private System.Windows.Forms.TextBox txtNamaDev;
        private System.Windows.Forms.ComboBox cmbIdProyek;
        private System.Windows.Forms.ComboBox cmbStatusKontrak;
        private System.Windows.Forms.TextBox txtFturSelesai;
        private System.Windows.Forms.TextBox txtJumlahBug;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPerforma;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpDataDeveloper = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtJumlahBug = new TextBox();
            txtFturSelesai = new TextBox();
            cmbStatusKontrak = new ComboBox();
            cmbIdProyek = new ComboBox();
            txtNamaDev = new TextBox();
            lblJumlahBug = new Label();
            lblFturSelesai = new Label();
            lblStatusKontrak = new Label();
            lblIdProyek = new Label();
            lblNamaDev = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvPerforma = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            grpDataDeveloper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerforma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // grpDataDeveloper
            // 
            grpDataDeveloper.Controls.Add(label6);
            grpDataDeveloper.Controls.Add(label5);
            grpDataDeveloper.Controls.Add(label4);
            grpDataDeveloper.Controls.Add(txtJumlahBug);
            grpDataDeveloper.Controls.Add(txtFturSelesai);
            grpDataDeveloper.Controls.Add(cmbStatusKontrak);
            grpDataDeveloper.Controls.Add(cmbIdProyek);
            grpDataDeveloper.Controls.Add(txtNamaDev);
            grpDataDeveloper.Controls.Add(lblJumlahBug);
            grpDataDeveloper.Controls.Add(lblFturSelesai);
            grpDataDeveloper.Controls.Add(lblStatusKontrak);
            grpDataDeveloper.Controls.Add(lblIdProyek);
            grpDataDeveloper.Controls.Add(lblNamaDev);
            grpDataDeveloper.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDataDeveloper.Location = new Point(12, 116);
            grpDataDeveloper.Name = "grpDataDeveloper";
            grpDataDeveloper.Size = new Size(818, 240);
            grpDataDeveloper.TabIndex = 0;
            grpDataDeveloper.TabStop = false;
            grpDataDeveloper.Text = "DATA DEVELOPER";
            grpDataDeveloper.Enter += grpDataDeveloper_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 134);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 14;
            label6.Text = "DATA KINERJA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 198);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 13;
            label5.Text = "(jumlah bug yg ditemukan)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(338, 169);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 12;
            label4.Text = "(jumlah fitur yg dikerjakan)";
            // 
            // txtJumlahBug
            // 
            txtJumlahBug.Location = new Point(150, 190);
            txtJumlahBug.Name = "txtJumlahBug";
            txtJumlahBug.Size = new Size(180, 23);
            txtJumlahBug.TabIndex = 9;
            // 
            // txtFturSelesai
            // 
            txtFturSelesai.Location = new Point(150, 161);
            txtFturSelesai.Name = "txtFturSelesai";
            txtFturSelesai.Size = new Size(180, 23);
            txtFturSelesai.TabIndex = 8;
            // 
            // cmbStatusKontrak
            // 
            cmbStatusKontrak.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusKontrak.FormattingEnabled = true;
            cmbStatusKontrak.Items.AddRange(new object[] { "Freelance", "Fulltime" });
            cmbStatusKontrak.Location = new Point(150, 98);
            cmbStatusKontrak.Name = "cmbStatusKontrak";
            cmbStatusKontrak.Size = new Size(180, 23);
            cmbStatusKontrak.TabIndex = 7;
            // 
            // cmbIdProyek
            // 
            cmbIdProyek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdProyek.FormattingEnabled = true;
            cmbIdProyek.Location = new Point(150, 69);
            cmbIdProyek.Name = "cmbIdProyek";
            cmbIdProyek.Size = new Size(180, 23);
            cmbIdProyek.TabIndex = 6;
            // 
            // txtNamaDev
            // 
            txtNamaDev.Location = new Point(150, 40);
            txtNamaDev.Name = "txtNamaDev";
            txtNamaDev.Size = new Size(180, 23);
            txtNamaDev.TabIndex = 5;
            // 
            // lblJumlahBug
            // 
            lblJumlahBug.AutoSize = true;
            lblJumlahBug.Font = new Font("Segoe UI", 9F);
            lblJumlahBug.Location = new Point(15, 193);
            lblJumlahBug.Name = "lblJumlahBug";
            lblJumlahBug.Size = new Size(69, 15);
            lblJumlahBug.TabIndex = 4;
            lblJumlahBug.Text = "Jumlah Bug";
            // 
            // lblFturSelesai
            // 
            lblFturSelesai.AutoSize = true;
            lblFturSelesai.Font = new Font("Segoe UI", 9F);
            lblFturSelesai.Location = new Point(15, 164);
            lblFturSelesai.Name = "lblFturSelesai";
            lblFturSelesai.Size = new Size(69, 15);
            lblFturSelesai.TabIndex = 3;
            lblFturSelesai.Text = "Fitur Selesai";
            // 
            // lblStatusKontrak
            // 
            lblStatusKontrak.AutoSize = true;
            lblStatusKontrak.Font = new Font("Segoe UI", 9F);
            lblStatusKontrak.Location = new Point(15, 101);
            lblStatusKontrak.Name = "lblStatusKontrak";
            lblStatusKontrak.Size = new Size(83, 15);
            lblStatusKontrak.TabIndex = 2;
            lblStatusKontrak.Text = "Status Kontrak";
            // 
            // lblIdProyek
            // 
            lblIdProyek.AutoSize = true;
            lblIdProyek.Font = new Font("Segoe UI", 9F);
            lblIdProyek.Location = new Point(15, 72);
            lblIdProyek.Name = "lblIdProyek";
            lblIdProyek.Size = new Size(57, 15);
            lblIdProyek.TabIndex = 1;
            lblIdProyek.Text = "ID Proyek";
            // 
            // lblNamaDev
            // 
            lblNamaDev.AutoSize = true;
            lblNamaDev.Font = new Font("Segoe UI", 9F);
            lblNamaDev.Location = new Point(15, 43);
            lblNamaDev.Name = "lblNamaDev";
            lblNamaDev.Size = new Size(95, 15);
            lblNamaDev.TabIndex = 0;
            lblNamaDev.Text = "Nama Developer";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.DarkOliveGreen;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(12, 371);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(110, 35);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(376, 371);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 35);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(720, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvPerforma
            // 
            dgvPerforma.AllowUserToAddRows = false;
            dgvPerforma.AllowUserToDeleteRows = false;
            dgvPerforma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerforma.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerforma.Location = new Point(12, 456);
            dgvPerforma.Name = "dgvPerforma";
            dgvPerforma.ReadOnly = true;
            dgvPerforma.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerforma.Size = new Size(818, 207);
            dgvPerforma.TabIndex = 5;
            dgvPerforma.SelectionChanged += dgvPerforma_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 20);
            label1.Name = "label1";
            label1.Size = new Size(283, 42);
            label1.TabIndex = 6;
            label1.Text = "Kucenggg Dev";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 75);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 7;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 50);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 421);
            label7.Name = "label7";
            label7.Size = new Size(185, 20);
            label7.TabIndex = 15;
            label7.Text = "DAFTAR PERFORMA TIM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(720, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(105, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 675);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPerforma);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(grpDataDeveloper);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KUCEEENGGG DEV : Developer Performance Tracker";
            Load += Form1_Load;
            grpDataDeveloper.ResumeLayout(false);
            grpDataDeveloper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerforma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}