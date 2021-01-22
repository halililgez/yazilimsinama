namespace proje3
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnToDoList = new System.Windows.Forms.Button();
            this.btnToDoEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEkleYapiliyor = new System.Windows.Forms.Button();
            this.btninprogress = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEkleYapilmis = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projeid = new System.Windows.Forms.Label();
            this.projeadinew = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.projezaman = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(771, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(395, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(771, 148);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragDrop);
            this.dataGridView2.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragOver);
            this.dataGridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDown);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(395, 487);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(771, 148);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView3_DragDrop);
            this.dataGridView3.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView3_DragOver);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnToDoList);
            this.groupBox1.Controls.Add(this.btnToDoEkle);
            this.groupBox1.Location = new System.Drawing.Point(60, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılacaklar";
            // 
            // btnToDoList
            // 
            this.btnToDoList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnToDoList.Location = new System.Drawing.Point(57, 80);
            this.btnToDoList.Name = "btnToDoList";
            this.btnToDoList.Size = new System.Drawing.Size(143, 36);
            this.btnToDoList.TabIndex = 1;
            this.btnToDoList.Text = "Yapılacakları Listele";
            this.btnToDoList.UseVisualStyleBackColor = false;
            this.btnToDoList.Click += new System.EventHandler(this.btnToDoList_Click);
            // 
            // btnToDoEkle
            // 
            this.btnToDoEkle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnToDoEkle.Location = new System.Drawing.Point(57, 29);
            this.btnToDoEkle.Name = "btnToDoEkle";
            this.btnToDoEkle.Size = new System.Drawing.Size(143, 36);
            this.btnToDoEkle.TabIndex = 0;
            this.btnToDoEkle.Text = "Yeni İş Ekle";
            this.btnToDoEkle.UseVisualStyleBackColor = false;
            this.btnToDoEkle.Click += new System.EventHandler(this.btnToDoEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.btnEkleYapiliyor);
            this.groupBox2.Controls.Add(this.btninprogress);
            this.groupBox2.Location = new System.Drawing.Point(60, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yapılıyor";
            // 
            // btnEkleYapiliyor
            // 
            this.btnEkleYapiliyor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEkleYapiliyor.Location = new System.Drawing.Point(57, 28);
            this.btnEkleYapiliyor.Name = "btnEkleYapiliyor";
            this.btnEkleYapiliyor.Size = new System.Drawing.Size(143, 36);
            this.btnEkleYapiliyor.TabIndex = 2;
            this.btnEkleYapiliyor.Text = "Yapılıyor Olan Bir İş Ekle";
            this.btnEkleYapiliyor.UseVisualStyleBackColor = false;
            this.btnEkleYapiliyor.Click += new System.EventHandler(this.btnEkleYapiliyor_Click);
            // 
            // btninprogress
            // 
            this.btninprogress.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btninprogress.Location = new System.Drawing.Point(57, 80);
            this.btninprogress.Name = "btninprogress";
            this.btninprogress.Size = new System.Drawing.Size(143, 36);
            this.btninprogress.TabIndex = 1;
            this.btninprogress.Text = "Yapılıyor Olanları Listele";
            this.btninprogress.UseVisualStyleBackColor = false;
            this.btninprogress.Click += new System.EventHandler(this.btninprogress_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.btnEkleYapilmis);
            this.groupBox3.Controls.Add(this.btnDone);
            this.groupBox3.Location = new System.Drawing.Point(60, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 139);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yapıldı";
            // 
            // btnEkleYapilmis
            // 
            this.btnEkleYapilmis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEkleYapilmis.Location = new System.Drawing.Point(57, 28);
            this.btnEkleYapilmis.Name = "btnEkleYapilmis";
            this.btnEkleYapilmis.Size = new System.Drawing.Size(143, 36);
            this.btnEkleYapilmis.TabIndex = 2;
            this.btnEkleYapilmis.Text = "Yapılmış Olan Bir İş Ekle";
            this.btnEkleYapilmis.UseVisualStyleBackColor = false;
            this.btnEkleYapilmis.Click += new System.EventHandler(this.btnEkleYapilmis_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDone.Location = new System.Drawing.Point(57, 82);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(143, 36);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Yapılmış Olanları Listeleri";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(391, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yapılacaklar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(392, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yapılıyor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(392, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yapıldı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proje ID:";
            // 
            // projeid
            // 
            this.projeid.AutoSize = true;
            this.projeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeid.Location = new System.Drawing.Point(112, 56);
            this.projeid.Name = "projeid";
            this.projeid.Size = new System.Drawing.Size(0, 20);
            this.projeid.TabIndex = 10;
            // 
            // projeadinew
            // 
            this.projeadinew.AutoSize = true;
            this.projeadinew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projeadinew.Location = new System.Drawing.Point(112, 21);
            this.projeadinew.Name = "projeadinew";
            this.projeadinew.Size = new System.Drawing.Size(0, 20);
            this.projeadinew.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Proje Adı:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1060, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projezaman
            // 
            this.projezaman.AutoSize = true;
            this.projezaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projezaman.Location = new System.Drawing.Point(1056, 21);
            this.projezaman.Name = "projezaman";
            this.projezaman.Size = new System.Drawing.Size(0, 20);
            this.projezaman.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(787, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Projenin Tahmini Bitiş Süresi :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1203, 669);
            this.Controls.Add(this.projezaman);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projeadinew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.projeid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMain";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnToDoList;
        private System.Windows.Forms.Button btnToDoEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btninprogress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkleYapiliyor;
        private System.Windows.Forms.Button btnEkleYapilmis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label projeid;
        private System.Windows.Forms.Label projeadinew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label projezaman;
        private System.Windows.Forms.Label label7;
    }
}

