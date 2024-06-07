using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace umutvar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Database.Start();
        }
        OleDbConnection ConnectionDataBase = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\deprem.mdb");
        OleDbCommand CommandDataBase = new OleDbCommand();

        private void Button_ShowDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDatabase();
            }
            catch 
            {
                MessageBox.Show("Veritabanına Ulaşılamadı!");
            }
        }
        private void ShowDatabase()
        {
            LView_MainTable.Items.Clear();
            ConnectionDataBase.Open();
            OleDbCommand cmdDatabase = new OleDbCommand();
            cmdDatabase.Connection = ConnectionDataBase;
            cmdDatabase.CommandText = ("Select * From deprem");
            OleDbDataReader readDatabase = cmdDatabase.ExecuteReader();
            while (readDatabase.Read())
            {
                ListViewItem addDatabese = new ListViewItem();
                addDatabese.Text = readDatabase["adsoyad"].ToString();
                addDatabese.SubItems.Add(readDatabase["tc"].ToString());
                addDatabese.SubItems.Add(readDatabase["kisi"].ToString());
                addDatabese.SubItems.Add(readDatabase["tel"].ToString());
                addDatabese.SubItems.Add(readDatabase["adres"].ToString());
                addDatabese.SubItems.Add(readDatabase["yardim"].ToString());
                addDatabese.SubItems.Add(readDatabase["sayfa"].ToString());
                addDatabese.SubItems.Add(readDatabase["tarih"].ToString());
                LView_MainTable.Items.Add(addDatabese);

            }
            ConnectionDataBase.Close();
        }
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            ConnectionDataBase.Open();
            OleDbCommand saveData = 
                new OleDbCommand("insert into deprem (adsoyad,tc,kisi,tel,adres,yardim,tarih) values ('" 
                + TBox_Ad.Text.ToString() + "','" 
                + TBox_Tc.Text.ToString() + "','" 
                + TBox_Soyad.Text.ToString() + "','" 
                + TBox_Telefon.Text.ToString() + "','" 
                + TBox_Adres.Text.ToString() + "','" 
                + TBox_Malzeme.Text.ToString() + "','" 
                + TBox_Saat.Text.ToString() + "')", ConnectionDataBase);
            saveData.ExecuteNonQuery();
            ConnectionDataBase.Close();
            ShowDatabase();
            Clean_AllBox();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            ConnectionDataBase.Open();
            CommandDataBase.Connection = ConnectionDataBase;
            CommandDataBase.CommandText = "delete from deprem where tc='" + TBox_ID_Sil.Text + "'";
            CommandDataBase.ExecuteNonQuery();
            ConnectionDataBase.Close();
            ShowDatabase();
            Clean_AllBox();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchinDatabase();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchinDatabase();
        }
        private void SearchinDatabase()
        {
            LView_MainTable.Items.Clear();
            ConnectionDataBase.Open();
            OleDbCommand komut = new OleDbCommand("select * from deprem where tc like '%" + textBox2.Text + "%'", ConnectionDataBase);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["kisi"].ToString());
                ekle.SubItems.Add(oku["tel"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());
                ekle.SubItems.Add(oku["yardim"].ToString());
                ekle.SubItems.Add(oku["sayfa"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                LView_MainTable.Items.Add(ekle);
            }
            ConnectionDataBase.Close();
        }


        private void Timer_Database_Tick(object sender, EventArgs e)
        {
            TBox_Saat.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void Clean_AllBox()
        {
            TBox_Ad.Clear(); TBox_Soyad.Clear(); TBox_Tc.Clear(); TBox_Telefon.Clear(); TBox_Adres.Clear(); TBox_Malzeme.Clear(); TBox_Saat.Clear(); TBox_ID_Sil.Clear();
        }
    }
}