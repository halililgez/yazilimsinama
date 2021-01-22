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
    public partial class proje : Form
    {
        public int projeSayi = 0;
        public proje()
        {
            InitializeComponent();
        }
        /**sql server bağlantımızı gerçekleştiriyoruz.*/
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VSP1HDF;Initial Catalog=task_takip;Integrated Security=True");

        
        test pp = new test();
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            /**yeni proje açıldığında proje adını ve proje id sini oluşturup 2. forma atadık. */
            frmMain frm = new frmMain();
            frm.projeadi = textBox2.Text;
            /**projemize rastgele bir id veren kısım.*/
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000);
            frm.projeidnew = sayi;

            frm.Show();
            this.Hide();
            i++;
            projeSayi = pp.projeHesap(i);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /**Var olan bir projeyi açtığımız zaman istenilen id yi aldık ve gönderdik.*/
            frmMain frm = new frmMain();
            frm.projeidnew =Convert.ToInt32( textBox1.Text);
            baglanti.Open();
            
            /**Var olan proje için istenilen id de bulunan veritabanından proje adını çektik.*/
            String[] dizi = { "is_takip_table", "yapiliyor", "yapilmis" };

            /**datadaki tabloların bazılarının boş olabilme ihtimali için sadece bir tablodan değil tüm tablolardan proje adı verisini aradık bulduk çektik.*/
            for (int i = 0; i < dizi.Length; i++)
            {
                String s = "select * from  " + dizi[i];
                SqlCommand cmd1 = new SqlCommand(s, baglanti);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.HasRows)
                {
                    dr1.Read();
                    frm.projeadi = (string)dr1["projeadi"];
                    break;

                }

                else
                {
                    frm.projeadi = "";
                }
                dr1.Close();
            }
            frm.Show();
            this.Hide();
        }

      
        private void proje_Load(object sender, EventArgs e)
        {

        }
    }
}
