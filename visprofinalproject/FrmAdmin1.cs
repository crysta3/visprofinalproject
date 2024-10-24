using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace visprofinalproject
{
    public partial class FrmAdmin1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmAdmin1()
        {
            alamat = "server=localhost; database=db_bubble; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Hide();
        }

        private void FrmAdmin1_Load(object sender, EventArgs e)
        {
            try
            {
                // Membuka koneksi ke database
                koneksi.Open();

                // Query untuk mengambil data dari tabel
                string query = "SELECT * FROM tbl_cucibersih";

                // Membuat command untuk menjalankan query
                MySqlCommand perintah = new MySqlCommand(query, koneksi);

                // Menjalankan query dan membaca hasilnya
                MySqlDataReader reader = perintah.ExecuteReader();

                // Variabel untuk menentukan posisi awal label
                int posY = 30;
                int labelIndex = 1; // Untuk memberi nama unik pada label

                // Melakukan looping pada hasil query
                while (reader.Read())
                {
                    // Membuat Label baru untuk Nama Pengguna
                    Label labelNama = new Label();
                    labelNama.Text = "Nama Pengguna " + ": " + reader["nama"];
                    labelNama.Location = new System.Drawing.Point(30, posY); // Mengatur posisi label
                    this.Controls.Add(labelNama); // Menambah label ke form

                    // Membuat Label baru untuk Level
                    Label labelLevel = new Label();
                    labelLevel.Text = "Total " + ": " + reader["total"].ToString();
                    labelLevel.Location = new System.Drawing.Point(200, posY); // Mengatur posisi label
                    this.Controls.Add(labelLevel); // Menambah label ke form

                    // Menambah jarak untuk label berikutnya
                    posY += 30;
                    labelIndex++;
                }

                // Menutup reader dan koneksi
                reader.Close();
                koneksi.Close();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan kesalahan jika terjadi error
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
