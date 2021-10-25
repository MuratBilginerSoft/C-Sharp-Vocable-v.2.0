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
    public partial class Form2 : Form
    {
        /* * METODLARIM * */

        // Sözlük veri tabanına bağlanma metodu

        public static string ara()
        {
            try
            {
                
                string dosya = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=İngilizce Sözlük 2.accdb";
                OleDbConnection baglanti = new OleDbConnection(dosya);
                string sorgu = "select  * from KELİMELER";
                OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(komut);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                a = r.Next(0, tablo.Rows.Count);
                k = tablo.Rows[a]["WORD"].ToString();
                tur = tablo.Rows[a]["TYPE"].ToString();
                anlami = tablo.Rows[a]["MEANS"].ToString();
            }
            catch { };

            return k;


        }

        // label temizleme metodları

        public void calıstemizle()
        {
            label7.Text  = "";
            label8.Text  = "";
            label9.Text  = "";
            label29.Text = "";
        }

        public void tekrartemizle()
        {

            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label30.Text = "";
        }

        // label yazdırma metodları

        public void yazdır1()
        {

            label10.Text = pas1[t].ToString();
            label11.Text = pas2[t].ToString();
            label12.Text = pas3[t].ToString();
        }

        public void yazdır2()
        {
            label10.Text = pass1[t].ToString();
            label11.Text = pass2[t].ToString();
            label12.Text = pass3[t].ToString();
        }

        public void sil1()
        {
            pas1.Clear();
            pas2.Clear();
            pas3.Clear();
        }

        public void sil2()
        {
            tum1.Clear();
            tum2.Clear();
            tum3.Clear();
        }

        public void sil3()
        {
            pass1.Clear();
            pass2.Clear();
            pass3.Clear();
        }

        public static void degisken()
        {
            say1 = 0;   // Kelime çalışırkenki kaç kelime çalışılacak o sayıyı tutuyor.

            say2 = 0;   // Test ederkenki  kaç kelime test edilecek o sayıyı tutuyor.

            deg = 0;  // Çalışılacak sayıya ulaşıldığında döngüyü durduracak sayıyı tutuyor.

            

            p = 0;      // pas geçilen sayıyı tutacak.

            t = 0;    // tüm değerlerin sayısını tutacak.

            d1 = 0;   // hepsini butonunun birde fazla basıldığı değeri tutacak.

            d2 = 0;   // pas geçtiklerimi butonunun birden fazla basıldığı değeri tutacak

            u1 = 0;   // bu ifade pas geçtiklerimi tıklarsam 1 artacak ve pas geçtiğim kelimlerin gelmesini sağlayacak.

            u2 = 0;   // bu ifade hepsini tıklarsam 1 artacak ve tüm kelimelerin gelmesini sağlayacak.

            p1 = 0;   // ilk çalışmada her pas geçtiğim değerde 1 artacak

            p2 = 0;   // tekrar da pas geçtiğim her kelime içn 1 artacak

            y = 0;    // tekrar et bölümünde pas geçtiklerimi ifadesini tıkladığımda değeri bir artacak ifade.

            z1 = 0;   // kelime çalışda kelime geçtiğimde kaçıncı kelime olduğunu tutacak 

            z2 = 0;   // tekrarda kelime geçtiğimde kaçıncı kelime olduğunu tutacak.

          
        
        }
      
        /* * DİZİ TANIMLAMALARI * */

        // Kelime çalşırkenki geçilen tüm kelimeleri tutacak

       public static ArrayList tum1 = new ArrayList();
       public static ArrayList tum2 = new ArrayList();
       public static ArrayList tum3 = new ArrayList();

        // Kelime çalışırkenki pas geçilen kelimeleri tutacak

       public static ArrayList pas1 = new ArrayList();
       public static ArrayList pas2 = new ArrayList();
       public static ArrayList pas3 = new ArrayList();

        // Tekrar ederkenki pas geçtiklerimi tutacak

       public static ArrayList pass1 = new ArrayList();
       public static ArrayList pass2 = new ArrayList();
       public static ArrayList pass3 = new ArrayList();

        // Test et bölümünde pas geçilen kelimleri tutacak

       public static ArrayList past1 = new ArrayList();
       public static ArrayList past2 = new ArrayList();
       public static ArrayList past3 = new ArrayList();

        // Test bölümünde yanlış olan kelimeleri tutacak

       public static ArrayList yant1 = new ArrayList();
       public static ArrayList yant2 = new ArrayList();
       public static ArrayList yant3 = new ArrayList();

        // Rastgele değer üretme metodu

       public static Random r = new Random();

        /* * DEĞİŞKEN TANIMLAMALARI * */

        //  KELİME ÇALIŞ BÖLÜMÜ DEĞİŞKENLERİ

       public static int say1 = 0;   // Kelime çalışırkenki kaç kelime çalışılacak o sayıyı tutuyor.

       public static int say2 = 0;   // Test ederkenki  kaç kelime test edilecek o sayıyı tutuyor.

       public static int deg = 0;  // Çalışılacak sayıya ulaşıldığında döngüyü durduracak sayıyı tutuyor.

       public static int a;        // Tablodan gelen rastgele sayıyı tutuyor.

       public static int p = 0;      // pas geçilen sayıyı tutacak.

       public static int t = 0;    // tüm değerlerin sayısını tutacak.

       public static int d1 = 0;   // hepsini butonunun birde fazla basıldığı değeri tutacak.

       public static int d2 = 0;   // pas geçtiklerimi butonunun birden fazla basıldığı değeri tutacak

       public static int u1 = 0;   // bu ifade pas geçtiklerimi tıklarsam 1 artacak ve pas geçtiğim kelimlerin gelmesini sağlayacak.

       public static int u2 = 0;   // bu ifade hepsini tıklarsam 1 artacak ve tüm kelimelerin gelmesini sağlayacak.

       public static int p1 = 0;   // ilk çalışmada her pas geçtiğim değerde 1 artacak

       public static int p2 = 0;   // tekrar da pas geçtiğim her kelime içn 1 artacak

       public static int y = 0;    // tekrar et bölümünde pas geçtiklerimi ifadesini tıkladığımda değeri bir artacak ifade.

       public static int z1 = 0;   // kelime çalışda kelime geçtiğimde kaçıncı kelime olduğunu tutacak 

       public static int z2 = 0;   // tekrarda kelime geçtiğimde kaçıncı kelime olduğunu tutacak.

       public static int g1 = 0;   // formlar arası geçişte bir değişken

       public static int g2 = 0;   // tekrar et bölümünde kelime geçince 1 artacak.


       public static string k;     // metodda dönen kelimeyi tutuyor.

       public static string kelime; // Program içinde metoddan gelen kelimeyi tutacak.

       public static string tur;    // Metoddan gelecek türü tutacak.

       public static string anlami; // Metoddan gelecek anlamı tutacak.


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
        
        public Form2()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 482, 554, 15, 15));
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Kaç kelime çalışmak istiyorsunuz?";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            say1 = int.Parse(comboBox1.SelectedItem.ToString()); // Combobox içinden gelen değerin kodu.
            comboBox1.Visible = false;
            label29.Text = z1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g1++;
            try
            {
                if (comboBox1.Text == "Kaç kelime çalışmak istiyorsunuz?")
                {
                    MessageBox.Show("Lütfen kaç kelime çalışmak istediğinizi seçiniz.");
                }

                else if (deg < say1)
                {
                    kelime = ara();

                    {
                        // gelen değerlerin ekranda labellara yazdırdm

                        label7.Text = kelime;
                        label8.Text = tur;
                        label9.Text = anlami;
                        z1++;
                        label29.Text = z1.ToString();
                    }

                    {
                        // kelime geçildiğinde o geçilen kelimeyi diziye atadım.

                        tum1.Add(kelime);
                        tum2.Add(tur);
                        tum3.Add(anlami);

                    }

                    deg++; // döngüyü sağlıyacak değeri 1 artırdım
                }

                else
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    calıstemizle();
                    p2 = p1;
                    p1 = 0;
                    MessageBox.Show(say1 + " Kelime çalıştınız.Öğrenemediğiniz kelimeleri tekrar et bölümünden \nçalışabilirsiniz.");
                }
            }

            catch
            { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // pas geçilen kelimeleri diziye atadım
                p1++;
                pas1.Add(kelime);
                pas2.Add(tur);
                pas3.Add(anlami);
            }

            {
                // labelları temizledim

                calıstemizle();
                label29.Text = z1.ToString();
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (y % 2 != 0)
                {
                    if (p1 == 0)
                    {
                        sil3();
                        t--;
                    }

                    pass1.Add(tum1[t].ToString());
                    pass2.Add(tum2[t].ToString());
                    pass3.Add(tum3[t].ToString());

                    tekrartemizle();
                    label30.Text = g2.ToString();
                    p1++;
                }

                else
                {
                    if (p1 == 0)
                    {
                        sil1();
                        t--;

                    }

                    pas1.Add(tum1[t].ToString());
                    pas2.Add(tum2[t].ToString());
                    pas3.Add(tum3[t].ToString());

                    tekrartemizle();
                    label30.Text = g2.ToString();
                    p1++;
                }
            }

            catch { };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (u1 == 1)
                {
                    if (t < p2)
                    {
                        if (y % 2 != 0)
                        {
                            yazdır1();
                            g2++;
                            label30.Text = g2.ToString();
                        }

                        else
                        {
                            yazdır2();
                            g2++;
                            label30.Text = g2.ToString();
                        }
                        t++;
                    }

                    else
                    {
                       
                        u1 = 0;
                        p2 = p1;
                        p1 = 0;
                        t = 0;
                        g2 = 0;
                        tekrartemizle();
                        MessageBox.Show("Tüm kelimeleri tekrar çalıştınız.\nTekrar et bölümünden yeniden çalışabilirsiniz.");

                    }
                }

                else if (u2 == 1)
                {

                    if (t < say1)
                    {
                        label10.Text = tum1[t].ToString();
                        label11.Text = tum2[t].ToString();
                        label12.Text = tum3[t].ToString();
                        t++;
                        g2++;
                        label30.Text = g2.ToString();
                    }

                    else
                    {
                       
                        u2 = 0;
                        p2 = p1;
                        p1 = 0;
                        t = 0;
                        g2 = 0;
                        tekrartemizle();
                        MessageBox.Show("Tüm kelimeleri tekrar çalıştınız.\nTekrar et bölümünden yeniden çalışabilirsiniz.");
                    }
                }
            }

            catch { };
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

        private void kelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form1.frm4.ShowDialog();
                this.Show();
            }

            catch { };
        }

       
        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //sistemi sıfırlama

            degisken();

            // temizle tüm sistemi
            {
                sil1();
                sil2();
                sil3();
            }

            button1.Enabled = true;
            button2.Enabled = true;
            calıstemizle();
            tekrartemizle();
            comboBox1.Visible = true;
            comboBox1.Text = "Kaç kelime çalışmak istiyorsunuz?";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                sil1();

                label30.Text = g2.ToString();

                u2 = 1;

                if (d1 != 0)
                    t = 0;
                try
                {
                    label10.Text = tum1[t].ToString();
                    label11.Text = tum2[t].ToString();
                    label12.Text = tum3[t].ToString();
                   
                    d1++;
                    t++;
                    label30.Text = z2.ToString();
                }

                catch { };
            }


            else
            {
                if (p2 == 0)
                    MessageBox.Show("Pas geçtiğiniz kelime yoktur.");

                else
                {
                    label30.Text = g2.ToString();
                    y++;
                    u1 = 1;

                    if (d2 != 0)
                        t = 0;
                    try
                    {
                        if (y % 2 != 0)
                        {
                           
                            yazdır1();
                            d2++;
                            t++;
                        }

                        else
                        {
                            yazdır2();
                            d2++;
                            t++;
                        }
                    }
                    catch { };
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
