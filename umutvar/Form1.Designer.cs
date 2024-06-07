namespace umutvar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_ShowDatabase = new System.Windows.Forms.Button();
            this.LView_MainTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBox_Tc = new System.Windows.Forms.TextBox();
            this.TBox_Malzeme = new System.Windows.Forms.TextBox();
            this.TBox_Adres = new System.Windows.Forms.TextBox();
            this.TBox_Saat = new System.Windows.Forms.TextBox();
            this.TBox_Telefon = new System.Windows.Forms.TextBox();
            this.TBox_Soyad = new System.Windows.Forms.TextBox();
            this.TBox_Ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBox_ID_Sil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Timer_Database = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_ShowDatabase
            // 
            this.Button_ShowDatabase.Location = new System.Drawing.Point(12, 9);
            this.Button_ShowDatabase.Name = "Button_ShowDatabase";
            this.Button_ShowDatabase.Size = new System.Drawing.Size(1306, 23);
            this.Button_ShowDatabase.TabIndex = 0;
            this.Button_ShowDatabase.Text = "GÖSTER";
            this.Button_ShowDatabase.UseVisualStyleBackColor = true;
            this.Button_ShowDatabase.Click += new System.EventHandler(this.Button_ShowDatabase_Click);
            // 
            // LView_MainTable
            // 
            this.LView_MainTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LView_MainTable.HideSelection = false;
            this.LView_MainTable.HoverSelection = true;
            this.LView_MainTable.Location = new System.Drawing.Point(12, 38);
            this.LView_MainTable.Name = "LView_MainTable";
            this.LView_MainTable.ShowItemToolTips = true;
            this.LView_MainTable.Size = new System.Drawing.Size(1306, 301);
            this.LView_MainTable.TabIndex = 1;
            this.LView_MainTable.UseCompatibleStateImageBehavior = false;
            this.LView_MainTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD-SOYAD";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KİŞİ";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TEL";
            this.columnHeader4.Width = 158;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            this.columnHeader5.Width = 240;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "YARDIM";
            this.columnHeader6.Width = 378;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SAYFA";
            this.columnHeader7.Width = 133;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TARİH";
            this.columnHeader8.Width = 119;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(972, 24);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(75, 120);
            this.Btn_Kaydet.TabIndex = 2;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBox_Tc);
            this.groupBox1.Controls.Add(this.TBox_Malzeme);
            this.groupBox1.Controls.Add(this.TBox_Adres);
            this.groupBox1.Controls.Add(this.TBox_Saat);
            this.groupBox1.Controls.Add(this.TBox_Telefon);
            this.groupBox1.Controls.Add(this.TBox_Soyad);
            this.groupBox1.Controls.Add(this.TBox_Ad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_Kaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EKLE";
            // 
            // TBox_Tc
            // 
            this.TBox_Tc.Location = new System.Drawing.Point(80, 54);
            this.TBox_Tc.Name = "TBox_Tc";
            this.TBox_Tc.Size = new System.Drawing.Size(210, 20);
            this.TBox_Tc.TabIndex = 15;
            // 
            // TBox_Malzeme
            // 
            this.TBox_Malzeme.Location = new System.Drawing.Point(680, 24);
            this.TBox_Malzeme.Multiline = true;
            this.TBox_Malzeme.Name = "TBox_Malzeme";
            this.TBox_Malzeme.Size = new System.Drawing.Size(286, 120);
            this.TBox_Malzeme.TabIndex = 14;
            // 
            // TBox_Adres
            // 
            this.TBox_Adres.Location = new System.Drawing.Point(354, 28);
            this.TBox_Adres.Multiline = true;
            this.TBox_Adres.Name = "TBox_Adres";
            this.TBox_Adres.Size = new System.Drawing.Size(231, 116);
            this.TBox_Adres.TabIndex = 13;
            // 
            // TBox_Saat
            // 
            this.TBox_Saat.Location = new System.Drawing.Point(80, 132);
            this.TBox_Saat.Name = "TBox_Saat";
            this.TBox_Saat.Size = new System.Drawing.Size(210, 20);
            this.TBox_Saat.TabIndex = 12;
            // 
            // TBox_Telefon
            // 
            this.TBox_Telefon.Location = new System.Drawing.Point(80, 106);
            this.TBox_Telefon.Name = "TBox_Telefon";
            this.TBox_Telefon.Size = new System.Drawing.Size(210, 20);
            this.TBox_Telefon.TabIndex = 11;
            // 
            // TBox_Soyad
            // 
            this.TBox_Soyad.Location = new System.Drawing.Point(80, 80);
            this.TBox_Soyad.Name = "TBox_Soyad";
            this.TBox_Soyad.Size = new System.Drawing.Size(210, 20);
            this.TBox_Soyad.TabIndex = 10;
            // 
            // TBox_Ad
            // 
            this.TBox_Ad.Location = new System.Drawing.Point(80, 28);
            this.TBox_Ad.Name = "TBox_Ad";
            this.TBox_Ad.Size = new System.Drawing.Size(210, 20);
            this.TBox_Ad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "VERİLEN\r\nMALZEMELER:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ADRES: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SAAT: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "T.C. KİMLİK: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TELEFON: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KİŞİ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD SOYAD: ";
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(481, 19);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(328, 20);
            this.Btn_Sil.TabIndex = 4;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBox_ID_Sil);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Btn_Sil);
            this.groupBox2.Location = new System.Drawing.Point(12, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SİL";
            // 
            // TBox_ID_Sil
            // 
            this.TBox_ID_Sil.Location = new System.Drawing.Point(172, 19);
            this.TBox_ID_Sil.Name = "TBox_ID_Sil";
            this.TBox_ID_Sil.Size = new System.Drawing.Size(303, 20);
            this.TBox_ID_Sil.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "TC KİMLİK NUMARASI İLE SİL: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(833, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 52);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARAMA";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "T.C. KİMLİK: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "AD: ";
            // 
            // Timer_Database
            // 
            this.Timer_Database.Tick += new System.EventHandler(this.Timer_Database_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1322, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LView_MainTable);
            this.Controls.Add(this.Button_ShowDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UMUT VAR!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ShowDatabase;
        private System.Windows.Forms.ListView LView_MainTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBox_Malzeme;
        private System.Windows.Forms.TextBox TBox_Adres;
        private System.Windows.Forms.TextBox TBox_Saat;
        private System.Windows.Forms.TextBox TBox_Telefon;
        private System.Windows.Forms.TextBox TBox_Soyad;
        private System.Windows.Forms.TextBox TBox_Ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBox_ID_Sil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBox_Tc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer Timer_Database;
    }
}

