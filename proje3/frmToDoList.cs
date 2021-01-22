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
    public partial class frmToDoList : Form
    {
        public frmToDoList()
        {
            InitializeComponent();
        }

        /**değişkenlerimizi belirledik*/
        public int projeid1;
        public int projezaman = 0;
        public frmMain frm;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VSP1HDF;Initial Catalog=task_takip;Integrated Security=True");
        DataSet set1 = new DataSet();
        private void frmToDoList_Load(object sender, EventArgs e)
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
            SqlDataAdapter adapter = new SqlDataAdapter("select *from [is_takip_table] where projeid ='" + projeid1 + "'", baglanti);
            adapter.Fill(set1, "is_takip_table");
            dataGridView1.DataSource = set1.Tables["is_takip_table"];
            baglanti.Close();
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

        private void btnToDoGüncelle_Click(object sender, EventArgs e)
        {
            /**textboxlara giden verilerde yapılan değişiklikleri kaydedip veri tabanına yazdırdık.*/
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update [is_takip_table] set ad=@ad, kisi=@kisi, tarih=@tarih, aciklama=@aciklama where kartno=@kartno", baglanti);
            guncelle.Parameters.AddWithValue("@kartno", kartnosu.Text);
            guncelle.Parameters.AddWithValue("@tarih", txtTarih.Text);
            guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@kisi", txtKisi.Text);
            guncelle.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            set1.Tables["is_takip_table"].Clear();
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

        public int delete_Data(string s)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from [is_takip_table] where kartno='" + s + "'", baglanti);
            int i = 0;
            i = sil.ExecuteNonQuery();
            baglanti.Close();
            return i;
        }
        private void btnKaldır_Click(object sender, EventArgs e)
        {
            /**üstüne tıklanan veriyi tablodan ve veritabanından sildik.*/
            delete_Data(dataGridView1.CurrentRow.Cells["kartno"].Value.ToString());
            set1.Tables["is_takip_table"].Clear();
            Task_Goster();
            MessageBox.Show("Seçilen iş kaldırıldı.");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /**çok fazla olan görevler tablosuna kart numarasından görevleri arayan bir araç getirdik.*/
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select *from [is_takip_table] where kartno like'%"+txtKartNoAra.Text +"%'", baglanti);
            ara.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
