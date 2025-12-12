using System;
using System.Data;
using System.Windows.Forms;

namespace junpro_pradana
{
    public partial class Form1 : Form
    {
        private int selectedDevId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProyek();
            LoadDeveloperData();
            cmbStatusKontrak.SelectedIndex = 0;
        }

        private void LoadProyek()
        {
            try
            {
                string query = "SELECT id_proyek, nama_proyek FROM proyek ORDER BY id_proyek";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                cmbIdProyek.DataSource = dt;
                cmbIdProyek.DisplayMember = "nama_proyek";
                cmbIdProyek.ValueMember = "id_proyek";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading proyek: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDeveloperData()
        {
            try
            {
                string query = @"
                    SELECT 
                        d.id_developer AS ""ID"",
                        d.nama_dev AS ""Nama"",
                        p.nama_proyek AS ""Proyek"",
                        d.status_kontrak AS ""Status"",
                        d.ftur_selesai AS ""Fitur"",
                        d.jumlah_bug AS ""Bug"",
                        d.skor AS ""Skor"",
                        d.total_gaji AS ""Total Gaji""
                    FROM developer d
                    LEFT JOIN proyek p ON d.id_proyek = p.id_proyek
                    ORDER BY d.id_developer";

                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                dgvPerforma.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaDev.Text) ||
                    cmbIdProyek.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtFturSelesai.Text) ||
                    string.IsNullOrWhiteSpace(txtJumlahBug.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaDev = txtNamaDev.Text.Trim();
                string idProyek = cmbIdProyek.SelectedValue.ToString();
                string statusKontrak = cmbStatusKontrak.SelectedItem.ToString();
                int fturSelesai = int.Parse(txtFturSelesai.Text);
                int jumlahBug = int.Parse(txtJumlahBug.Text);

                string queryBudget = $"SELECT budget FROM proyek WHERE id_proyek = '{idProyek}'";
                DataTable dtBudget = DatabaseHelper.ExecuteQuery(queryBudget);
                decimal budget = Convert.ToDecimal(dtBudget.Rows[0]["budget"]);

                // POLYMORPHISM: Menggunakan inheritance untuk membuat object yang sesuai
                Developer dev;
                if (statusKontrak == "Freelance")
                {
                    dev = new FreelanceDeveloper();
                }
                else
                {
                    dev = new FulltimeDeveloper();
                }

                // Set properties
                dev.NamaDev = namaDev;
                dev.IdProyek = idProyek;
                dev.FturSelesai = fturSelesai;
                dev.JumlahBug = jumlahBug;

                // Polymorphism: Method yang sama, tapi implementasi berbeda
                dev.HitungSkor(budget, fturSelesai);
                dev.HitungTotalGaji(budget, 10, dev.Skor);

                string queryInsert = $@"
            INSERT INTO developer (nama_dev, id_proyek, status_kontrak, ftur_selesai, jumlah_bug, skor, total_gaji)
            VALUES ('{namaDev}', '{idProyek}', '{statusKontrak}', {fturSelesai}, {jumlahBug}, {dev.Skor}, {dev.TotalGaji})";

                DatabaseHelper.ExecuteNonQuery(queryInsert);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDeveloperData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
/*
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaDev.Text) ||
                    cmbIdProyek.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtFturSelesai.Text) ||
                    string.IsNullOrWhiteSpace(txtJumlahBug.Text))
                {
                    MessageBox.Show("Semua field harus diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil data input
                string namaDev = txtNamaDev.Text.Trim();
                string idProyek = cmbIdProyek.SelectedValue.ToString();
                string statusKontrak = cmbStatusKontrak.SelectedItem.ToString();
                int fturSelesai = int.Parse(txtFturSelesai.Text);
                int jumlahBug = int.Parse(txtJumlahBug.Text);

                // Ambil budget proyek
                string queryBudget = $"SELECT budget FROM proyek WHERE id_proyek = '{idProyek}'";
                DataTable dtBudget = DatabaseHelper.ExecuteQuery(queryBudget);
                decimal budget = Convert.ToDecimal(dtBudget.Rows[0]["budget"]);

                // Hitung skor dan gaji
                Developer dev = new Developer
                {
                    NamaDev = namaDev,
                    IdProyek = idProyek,
                    StatusKontrak = statusKontrak,
                    FturSelesai = fturSelesai,
                    JumlahBug = jumlahBug
                };

                dev.HitungSkor(budget, fturSelesai);
                //dev.HitungTotalGaji(budget, 10, dev.Skor); // Asumsi fitur pokok = 10%

                // Insert ke database
                string queryInsert = $@"
                    INSERT INTO developer (nama_dev, id_proyek, status_kontrak, ftur_selesai, jumlah_bug, skor, total_gaji)
                    VALUES ('{namaDev}', '{idProyek}', '{statusKontrak}', {fturSelesai}, {jumlahBug}, {dev.Skor}, {dev.TotalGaji})";

                DatabaseHelper.ExecuteNonQuery(queryInsert);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDeveloperData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedDevId == -1)
                {
                    MessageBox.Show("Pilih developer dari tabel terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi sama seperti insert
                string namaDev = txtNamaDev.Text.Trim();
                string idProyek = cmbIdProyek.SelectedValue.ToString();
                string statusKontrak = cmbStatusKontrak.SelectedItem.ToString();
                int fturSelesai = int.Parse(txtFturSelesai.Text);
                int jumlahBug = int.Parse(txtJumlahBug.Text);

                string queryBudget = $"SELECT budget FROM proyek WHERE id_proyek = '{idProyek}'";
                DataTable dtBudget = DatabaseHelper.ExecuteQuery(queryBudget);
                decimal budget = Convert.ToDecimal(dtBudget.Rows[0]["budget"]);

                Developer dev;
                if (statusKontrak == "Freelance")
                {
                    dev = new FreelanceDeveloper();
                }
                else
                {
                    dev = new FulltimeDeveloper();
                }

                dev.StatusKontrak = statusKontrak;
                dev.FturSelesai = fturSelesai;
                dev.JumlahBug = jumlahBug;

                //Developer dev = new Developer
                //{
                //    StatusKontrak = statusKontrak,
                //    FturSelesai = fturSelesai,
                //    JumlahBug = jumlahBug
                //};

                dev.HitungSkor(budget, fturSelesai);
                //dev.HitungTotalGaji(budget, 10, dev.Skor);

                string queryUpdate = $@"
                    UPDATE developer 
                    SET nama_dev = '{namaDev}', 
                        id_proyek = '{idProyek}', 
                        status_kontrak = '{statusKontrak}', 
                        ftur_selesai = {fturSelesai}, 
                        jumlah_bug = {jumlahBug},
                        skor = {dev.Skor},
                        total_gaji = {dev.TotalGaji}
                    WHERE id_developer = {selectedDevId}";

                DatabaseHelper.ExecuteNonQuery(queryUpdate);
                MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDeveloperData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedDevId == -1)
                {
                    MessageBox.Show("Pilih developer dari tabel terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string queryDelete = $"DELETE FROM developer WHERE id_developer = {selectedDevId}";
                    DatabaseHelper.ExecuteNonQuery(queryDelete);
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDeveloperData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPerforma_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPerforma.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPerforma.SelectedRows[0];
                selectedDevId = Convert.ToInt32(row.Cells["ID"].Value);

                txtNamaDev.Text = row.Cells["Nama"].Value.ToString();

                // Cari ID proyek berdasarkan nama
                string namaProyek = row.Cells["Proyek"].Value.ToString();
                for (int i = 0; i < cmbIdProyek.Items.Count; i++)
                {
                    DataRowView drv = (DataRowView)cmbIdProyek.Items[i];
                    if (drv["nama_proyek"].ToString() == namaProyek)
                    {
                        cmbIdProyek.SelectedIndex = i;
                        break;
                    }
                }

                cmbStatusKontrak.SelectedItem = row.Cells["Status"].Value.ToString();
                txtFturSelesai.Text = row.Cells["Fitur"].Value.ToString();
                txtJumlahBug.Text = row.Cells["Bug"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtNamaDev.Clear();
            txtFturSelesai.Clear();
            txtJumlahBug.Clear();
            cmbIdProyek.SelectedIndex = 0;
            cmbStatusKontrak.SelectedIndex = 0;
            selectedDevId = -1;

            //lblNama.Text = "Nama: -";
            //lblProyek.Text = "Proyek: -";
            //lblStatus.Text = "Status: -";
            //lblFtur.Text = "Fitur: 0";
            //lblBug.Text = "Bug: 0";
            //lblSkor.Text = "Skor: 0";
            //lblTotalGaji.Text = "TOTAL GAJI: Rp 0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpDataDeveloper_Enter(object sender, EventArgs e)
        {

        }
    }
}