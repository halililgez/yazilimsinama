using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje3
{
    public partial class frmYapilmisListele : Form
    {
        public frmYapilmisListele()
        {
            InitializeComponent();
        }

        /**değişkenlerimizi belirledik*/
        public int projeid1;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VSP1HDF;Initial Catalog=task_takip;Integrated Security=True");
        DataSet set3 = new DataSet();
        private void frmYapilmisListele_Load(object sender, EventArgs e)
        {
            /**form yüklenirken fonksiyonlarımızı çağırdık.*/
            Task_Goster();
            Set_DataGridView();
        }

        private void Set_DataGridView()
        {
            /**datagrid içerisindeki verilen tam olarak görüntülenmesini sağladık*/
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Task_Goster()
        {
            /**istenilen projeid sinde yer alan görevleri getirip listeledik.*/
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from [yapilmis] where projeid ='" + projeid1 + "'", baglanti);
            adapter.Fill(set3, "yapilmis");
            dataGridView1.DataSource = set3.Tables["yapilmis"];
            baglanti.Close();
        }

        private void btnToDoGüncelle_Click(object sender, EventArgs e)
        {
            /**textboxlara giden verilerde yapılan değişiklikleri kaydedip veri tabanına yazdırdık.*/
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update [yapilmis] set ad=@ad, kisi=@kisi, tarih=@tarih, aciklama=@aciklama where kartno=@kartno", baglanti);
            guncelle.Parameters.AddWithValue("@kartno", kartnosu.Text);
            guncelle.Parameters.AddWithValue("@tarih", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@kisi", txtKisi.Text);
            guncelle.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            set3.Tables["yapilmis"].Clear();
            Task_Goster();
            MessageBox.Show("Seçilen iş güncellendi.");

            /**veriler güncellendikten sonra textboxları boşalttık.*/
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /**üstüne tıklanılan görevin verilerini textboxlara yerleştirdik.*/
            txtAd.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            txtKisi.Text = dataGridView1.CurrentRow.Cells["kisi"].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells["tarih"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
            kartnosu.Text = dataGridView1.CurrentRow.Cells["kartno"].Value.ToString();
        }

        private void btnKaldır_Click(object sender, EventArgs e)
        {
            /**üstüne tıklanan veriyi tablodan ve veritabanından sildik.*/
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from [yapilmis] where kartno='" + dataGridView1.CurrentRow.Cells["kartno"].Value.ToString() + "'", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            set3.Tables["yapilmis"].Clear();
            Task_Goster();
            MessageBox.Show("Seçilen iş kaldırıldı.");
        }

        private void txtKartNoAra_TextChanged(object sender, EventArgs e)
        {
            /**çok fazla olan görevler tablosuna kart numarasından görevleri arayan bir araç getirdik.*/
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select *from [yapilmis] where kartno like'%" + txtKartNoAra.Text + "%'", baglanti);
            ara.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
