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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /**değişkenlerimizi belirledik*/
         public string projeadi;
         public int projeidnew;
         public int topZaman ;
         public int todoZaman ;
         public int yapiliyorZaman ;


        /**sql bağlantı adresimizi yazdık.*/
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VSP1HDF;Initial Catalog=task_takip;Integrated Security=True");
       
        /**datalarımızı atadığımız geçici setleri belirledik*/
        DataSet set1 = new DataSet();
        DataSet set2 = new DataSet();
        DataSet set3 = new DataSet();

        test zaman = new test();


        private void btnToDoEkle_Click(object sender, EventArgs e)
        {
            /** to do tasklarını ekleme ekranına gidecek. orada yer alan id ve isim verisi gönderildi.*/
            frmToDo ekle = new frmToDo(); 
            ekle.projeadiadi = projeadi;
            ekle.projeid1 = projeidnew;
            ekle.frm = this;
            ekle.ShowDialog();

        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {
            /** to do tasklarını listeleme ekranına gidecek. orada yer alan id verisi gönderildi.*/
            frmToDoList listele = new frmToDoList();
            listele.projeid1 = projeidnew;
            listele.ShowDialog();
          
        }

        private void btnEkleYapiliyor_Click(object sender, EventArgs e)
        {
            /** in progress tasklarını ekleme ekranına gidecek. orada yer alan id ve isim verisi gönderildi.*/
            frmYapiliyor yapiliyor = new frmYapiliyor();
            yapiliyor.projeadiadi = projeadi;
            yapiliyor.projeid1 = projeidnew;
            yapiliyor.frmmm = this;
            yapiliyor.ShowDialog();
          
        }

        private void btninprogress_Click(object sender, EventArgs e)
        {
            /** in progress tasklarını listeleme ekranına gidecek. orada yer alan id verisi gönderildi.*/
            frmYapiliyorListele yapiliyorlistele = new frmYapiliyorListele();
            yapiliyorlistele.projeid1 = projeidnew;
            yapiliyorlistele.ShowDialog();
            
        }

        private void btnEkleYapilmis_Click(object sender, EventArgs e)
        {
            /** done tasklarını ekleme ekranına gidecek. orada yer alan id ve isim verisi gönderildi.*/
            frmYapilmis yapilmis = new frmYapilmis();
            yapilmis.projeadiadi = projeadi;
            yapilmis.projeid1 = projeidnew;
            yapilmis.frmm = this;
            yapilmis.ShowDialog();
          
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            /** done tasklarını listeleme ekranına gidecek. orada yer alan id verisi gönderildi.*/
            frmYapilmisListele yapilmislistele = new frmYapilmisListele();
            yapilmislistele.projeid1 = projeidnew;
            yapilmislistele.ShowDialog();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            /**form ilk yüklendiğinde zamanı ayarladık ve fonksiyonları çağırdık*/
            projezaman.Text = topZaman.ToString();
            Task_Goster();
            Set_DataGridView();
            projeid.Text = Convert.ToString(projeidnew);
            projeadinew.Text = projeadi;

        }


        private void Set_DataGridView()
        {

            /**datagridlerin içindeki tabloların tam olarak görünmesini sağladık.*/
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Task_Goster()
        {
            int i = -2; 
            
            /**istenilen projeid sindeki taskları tüm datagridlerde görünteleme fonksiyonumuz.*/
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from [is_takip_table] where projeid ='" +projeidnew+"'", baglanti);            
            adapter.Fill(set1, "is_takip_table");
            dataGridView1.DataSource = set1.Tables["is_takip_table"];
            i += dataGridView1.RowCount;
            SqlDataAdapter adapter2 = new SqlDataAdapter("select *from [yapiliyor] where projeid ='" + projeidnew + "'", baglanti);   
            adapter2.Fill(set2, "yapiliyor");
            dataGridView2.DataSource = set2.Tables["yapiliyor"];
            i += dataGridView2.RowCount;
            SqlDataAdapter adapter3 = new SqlDataAdapter("select *from [yapilmis] where projeid ='" + projeidnew + "'", baglanti);
            adapter3.Fill(set3, "yapilmis");
            dataGridView3.DataSource = set3.Tables["yapilmis"];
            baglanti.Close();

            projezaman.Text = zaman.gunHesapla(i).ToString();
        }

        

        /**sürükle bırak işlemi başlangıç*/
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            /**mouse ile datagridte tıklanılan yeri belirledik*/
            int SourceRow;
            SourceRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView1.DoDragDrop(SourceRow, DragDropEffects.Copy);

        }

        private void dataGridView2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            
            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point clientPoint = dataGridView2.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView2.HitTest(clientPoint.X, clientPoint.Y);
            if(hit.Type == DataGridViewHitTestType.Cell)
            {
                /**sürüklenilen veriyi ekilen datagridten sildik.*/
                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from [is_takip_table] where kartno='" + dataGridView1.CurrentRow.Cells["kartno"].Value.ToString() + "'", baglanti);
                sil.ExecuteNonQuery();

                /**sürüklenilen veriyi eklenen dataya ekledik.*/
                SqlCommand yeniis = new SqlCommand("insert into [yapiliyor](projeid,projeadi,kartno,tarih,ad,kisi,aciklama) values(@projeid,@projeadi,@kartno,@tarih,@ad,@kisi,@aciklama)", baglanti);
                yeniis.Parameters.AddWithValue("@projeadi", dataGridView1.CurrentRow.Cells[1].Value);
                yeniis.Parameters.AddWithValue("@projeid", dataGridView1.CurrentRow.Cells[0].Value);
                yeniis.Parameters.AddWithValue("@kartno", dataGridView1.CurrentRow.Cells[2].Value);
                yeniis.Parameters.AddWithValue("@tarih", dataGridView1.CurrentRow.Cells[3].Value);
                yeniis.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells[4].Value);
                yeniis.Parameters.AddWithValue("@kisi", dataGridView1.CurrentRow.Cells[5].Value);
                yeniis.Parameters.AddWithValue("@aciklama", dataGridView1.CurrentRow.Cells[6].Value);
                yeniis.ExecuteNonQuery();
                baglanti.Close();
                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;

                for(int u=0; u<6; u++)
                {
                    dataGridView2.Rows[DestRow].Cells[u].Value = dataGridView1.Rows[SourceRow].Cells[u].Value;
                }
                
            }
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            /**mouse ile datagridte tıklanılan yeri belirledik*/
            int SourceRow;
            SourceRow = dataGridView2.HitTest(e.X, e.Y).RowIndex;
            dataGridView1.DoDragDrop(SourceRow, DragDropEffects.Copy);
        }

        private void dataGridView3_DragDrop(object sender, DragEventArgs e)
        {
            int SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point clientPoint = dataGridView3.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dataGridView3.HitTest(clientPoint.X, clientPoint.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                /**sürüklenilen veriyi ekilen datagridten sildik.*/
                baglanti.Open();
                SqlCommand sil = new SqlCommand("delete from [yapiliyor] where kartno='" + dataGridView2.CurrentRow.Cells["kartno"].Value.ToString() + "'", baglanti);
                sil.ExecuteNonQuery();

                /**sürüklenilen veriyi eklenen dataya ekledik.*/
                SqlCommand yeniis = new SqlCommand("insert into [yapilmis](projeid,projeadi,kartno,tarih,ad,kisi,aciklama) values(@projeid,@projeadi,@kartno,@tarih,@ad,@kisi,@aciklama)", baglanti);
                yeniis.Parameters.AddWithValue("@projeadi", dataGridView2.CurrentRow.Cells[1].Value);
                yeniis.Parameters.AddWithValue("@projeid", dataGridView2.CurrentRow.Cells[0].Value);
                yeniis.Parameters.AddWithValue("@kartno", dataGridView2.CurrentRow.Cells[2].Value);
                yeniis.Parameters.AddWithValue("@tarih", dataGridView2.CurrentRow.Cells[3].Value);
                yeniis.Parameters.AddWithValue("@ad", dataGridView2.CurrentRow.Cells[4].Value);
                yeniis.Parameters.AddWithValue("@kisi", dataGridView2.CurrentRow.Cells[5].Value);
                yeniis.Parameters.AddWithValue("@aciklama", dataGridView2.CurrentRow.Cells[6].Value);
                yeniis.ExecuteNonQuery();
                baglanti.Close();

                int DestRow = hit.RowIndex;
                int DestCol = hit.ColumnIndex;

                for (int u = 0; u < 5; u++)
                {
                    dataGridView3.Rows[DestRow].Cells[u].Value = dataGridView2.Rows[SourceRow].Cells[u].Value;
                }

            }

        }

        private void dataGridView3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /**sürükle bırak işlemi son*/
        private void button1_Click(object sender, EventArgs e)
        {
            /**yenile butonu ekledik. tabloları her işlemden sonra yeniledik.*/

            set1.Clear();
            set2.Clear();
            set3.Clear();
            Task_Goster();
            
            
        }
    }
}
