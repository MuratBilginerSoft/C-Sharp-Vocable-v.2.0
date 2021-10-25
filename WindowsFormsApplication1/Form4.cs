using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        #region DLL Import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
         );

        #endregion

        public static int ara()
        {
            int k = 0;
            try
            {

                string dosya = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=İngilizce Sözlük 2.accdb";
                OleDbConnection baglanti = new OleDbConnection(dosya);
                string sorgu = "select  * from KELİMELER";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                k = tablo.Rows.Count;
            }
            catch { };

            return k;


        }
        private void kaydet()
        { 
          string dosya = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=İngilizce Sözlük 2.accdb";
          OleDbConnection baglanti = new OleDbConnection(dosya);
          OleDbCommand kaydet=new OleDbCommand("insert into KELİMELER(ID,WORD,MEANS,TYPE) values ('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "' )", baglanti);
          baglanti.Open();
          kaydet.ExecuteNonQuery();
          baglanti.Close();
        }
      
        public Form4()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 516, 464, 15, 15));
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                this.Show();
            }

            catch { };
        }

        private void kelimeÇalışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1.frm2.ShowDialog();
                this.Show();
            }

            catch { };
        }

        private void testEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1.frm3.ShowDialog();
                this.Show();
            }

            catch { };
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }

            catch { };
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            label15.Text = "Şu anda veri tabanınızda " + ara() + " tane kelime var.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    kaydet();
                    label15.Text = "Şu anda veri tabanınızda " + ara() + " tane kelime var.";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }

                else
                    MessageBox.Show("Doldurmadığınız alanlar var doldurup tekrar deneyiniz.");
            }

            catch { };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
