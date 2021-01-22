﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje3
{
    public partial class frmYapiliyor : Form
    {
        public frmYapiliyor()
        {
            InitializeComponent();
        }
        /**değişkenlerimizi belirledik*/
        public string projeadiadi;
        public int projeid1;
        public frmMain frmmm;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VSP1HDF;Initial Catalog=task_takip;Integrated Security=True");
        private void frmYapiliyor_Load(object sender, EventArgs e)
        {
            /**her bir göreve random bir kart numarası belirledik.*/
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000);
            kartnosu.Text = Convert.ToString(sayi);
            projeadilabel.Text = projeadiadi;

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            /**girilen verilerle taskı oluşturduk ve veritabanına yazdırdık.*/
            baglanti.Open();
            SqlCommand yeniis = new SqlCommand("insert into [yapiliyor](projeid,projeadi,kartno,tarih,ad,kisi,aciklama) values(@projeid,@projeadi,@kartno,@tarih,@ad,@kisi,@aciklama)", baglanti);
            yeniis.Parameters.AddWithValue("@projeid",projeid1 );
            yeniis.Parameters.AddWithValue("@projeadi", projeadiadi);
            yeniis.Parameters.AddWithValue("@kartno", kartnosu.Text);
            yeniis.Parameters.AddWithValue("@tarih", txtTarih.Text);
            yeniis.Parameters.AddWithValue("@ad", txtAd.Text);
            yeniis.Parameters.AddWithValue("@kisi", txtKisi.Text);
            yeniis.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            yeniis.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni iş eklendi.");

            /**yazı yazılan yerleri temizledik.*/
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            /**zaman sayacımız*/
            frmmm.topZaman += 1;
            this.Close();
        }


    }
}
