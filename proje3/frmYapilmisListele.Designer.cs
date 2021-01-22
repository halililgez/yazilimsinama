namespace proje3
{
    partial class frmYapilmisListele
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKartNoAra = new System.Windows.Forms.TextBox();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToDoGüncelle = new System.Windows.Forms.Button();
            this.kartnosu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Kart No Ara :";
            // 
            // txtKartNoAra
            // 
            this.txtKartNoAra.Location = new System.Drawing.Point(136, 52);
            this.txtKartNoAra.Name = "txtKartNoAra";
            this.txtKartNoAra.Size = new System.Drawing.Size(138, 20);
            this.txtKartNoAra.TabIndex = 55;
            this.txtKartNoAra.TextChanged += new System.EventHandler(this.txtKartNoAra_TextChanged);
            // 
            // btnKaldır
            // 
            this.btnKaldır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaldır.Location = new System.Drawing.Point(680, 52);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(97, 33);
            this.btnKaldır.TabIndex = 54;
            this.btnKaldır.Text = "İŞİ SİL";
            this.btnKaldır.UseVisualStyleBackColor = true;
            this.btnKaldır.Click += new System.EventHandler(this.btnKaldır_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(765, 281);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnToDoGüncelle
            // 
            this.btnToDoGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToDoGüncelle.Location = new System.Drawing.Point(646, 507);
            this.btnToDoGüncelle.Name = "btnToDoGüncelle";
            this.btnToDoGüncelle.Size = new System.Drawing.Size(131, 36);
            this.btnToDoGüncelle.TabIndex = 52;
            this.btnToDoGüncelle.Text = "GÜNCELLE";
            this.btnToDoGüncelle.UseVisualStyleBackColor = true;
            this.btnToDoGüncelle.Click += new System.EventHandler(this.btnToDoGüncelle_Click);
            // 
            // kartnosu
            // 
            this.kartnosu.AutoSize = true;
            this.kartnosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kartnosu.Location = new System.Drawing.Point(649, 465);
            this.kartnosu.Name = "kartnosu";
            this.kartnosu.Size = new System.Drawing.Size(0, 24);
            this.kartnosu.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(518, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Kart No :";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(608, 427);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(170, 20);
            this.txtTarih.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(518, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tarih :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(180, 523);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(342, 20);
            this.txtAciklama.TabIndex = 47;
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(180, 471);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(220, 20);
            this.txtKisi.TabIndex = 46;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(180, 426);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(220, 20);
            this.txtAd.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "İşin Açıklaması :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Yapacak Kişi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "İşin Adı :";
            // 
            // frmYapilmisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKartNoAra);
            this.Controls.Add(this.btnKaldır);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnToDoGüncelle);
            this.Controls.Add(this.kartnosu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmYapilmisListele";
            this.Text = "Yapılmış Olan İşleri Listele";
            this.Load += new System.EventHandler(this.frmYapilmisListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKartNoAra;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToDoGüncelle;
        private System.Windows.Forms.Label kartnosu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}