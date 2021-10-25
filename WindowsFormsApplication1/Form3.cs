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
    public partial class Form3 : Form
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

        public static string anlami;

        public static string tur;
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
        public void temizledt()
        {
            label5.Text = "";
            label18.Text = "";
            label20.Text = "";
            textBox1.Text = "";
        
        }

        public void temizleya()
        {
            label2_14.Text = "";
            label2_16.Text = "";
            label2_18.Text = "";
        }

        public void temizlepa()
        {
            label17.Text = "";
            label24.Text = "";
            label25.Text = "";
        
        
        }

        public void enabf()
        {
            button7.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

        
        }

        public void enabt()
        {
            button7.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

        
        }

        ///* * DİZİ TANIMLAMALARI * */

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

      
        // Rastgele değer üretme metodu

        public static Random r = new Random();

        ArrayList past1 = new ArrayList();
        ArrayList past2 = new ArrayList();
        ArrayList past3 = new ArrayList();

        // Test bölümünde yanlış olan kelimeleri tutacak

        ArrayList yant1 = new ArrayList();
        ArrayList yant2 = new ArrayList();
        ArrayList yant3 = new ArrayList();

        
        /* * DEĞİŞKEN TANIMLAMALARI * */

        //  KELİME ÇALIŞ BÖLÜMÜ DEĞİŞKENLERİ

        public static int say1 = 0;   // Kelime çalışırkenki kaç kelime çalışılacak o sayıyı tutuyor.

        

       

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

       
        public static int g1 = 0;   // formlar arası geçişte bir değişken

        public static int g2 = 0;   // tekrar et bölümünde kelime geçince 1 artacak.


        public static string k;     // metodda dönen kelimeyi tutuyor.

       

        // TEST ET BÖLÜMÜ DEĞİŞKENLERİ

        int say2 = 0;   // comboboxtan gelen değeri tutacak.

        int s1 = 0;     // çalıştığım kelimeleri getir derse 1 artacak

        int s2 = 0;     // rastgele kelimeleri getir derse 1 artacak.

        int s3 = 0;     // kelime getire basıldığında 1 artacak.

        int s7 = 0;     // rasgele dediğinde kelime sayısını tutacak.

        int s4 = 0;     // yanlış kelimeleri tutmak için 1 artacak.

        int s5 = 0;     // pas kelimeleri tutmak için 1 artacak.

        int s6 = 0;    // pas geçtiğim kelimeleri getirirken kullanılacak.

        int s9= 0;     // yanlış kelimeleri getirmek için 1 artacak.

        int s8 = 0;     // pas kelimeleri getirmek için 1 artacak.

        int dogru = 0;  // doğru sayısını tutacak.

        int yanlıs = 0; // yanlış sayısını tutacak.

        int pas = 0;    // pas sayısını tutacak.

        int z2 = 0;     // kelime geçtiğinde kaç kelime olduğunu tutacak

        int deg = 0;

       

        

        string kelime;

        string sonuckelime;   // sonuca tıklanınca kelimeyi bu değişkene atayacak.

        string bolünenkelime; // substring metoduyla böldüğüm kelimeyi tutacak.

        string aranankelime;  // textboxa girilen kelime.
/* ***********************************************************************************************************************************************************************************************/
       
        public Form3()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 849, 476, 15, 15));
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            z2++;
            s1++;
            label2_8.Text = dogru.ToString();
            label2_10.Text = yanlıs.ToString();
            label2_12.Text = pas.ToString();
            label5.Text = z2.ToString();


            checkBox1.Visible = false;
            checkBox2.Visible = false;
            label18.Text = Form2.tum1[s3].ToString();
            label20.Text = Form2.tum2[s3].ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                s2++;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                comboBox1.Visible = true;
                comboBox1.Text = "Kaç kelime çalışmak istiyorsunuz?";
                Form2.ara();
            }

            catch { };
        }

        private void button7_Click(object sender, EventArgs e)
        {
           


            if (s1 != 0)
            {
                try
                {

                    if (textBox1.Text == "")
                    {
                    
                        if (z2 < say2)
                        {
                            s5++;
                            label2_12.Text = s5.ToString();
                            label18.Text = "";
                            label20.Text = "";
                            textBox1.Text = "";

                            past1.Add(Form2.tum1[s3].ToString());
                            past2.Add(Form2.tum2[s3].ToString());
                            past3.Add(Form2.tum3[s3].ToString());
                            s3++;
                            z2++;
                            label5.Text = z2.ToString();
                            label18.Text = Form2.tum1[s3].ToString();
                            label20.Text = Form2.tum2[s3].ToString();
                        }

                        else
                        {
                            past1.Add(Form2.tum1[s3].ToString());
                            past2.Add(Form2.tum2[s3].ToString());
                            past3.Add(Form2.tum3[s3].ToString());
                            s5++;
                            label2_12.Text = s5.ToString();
                            MessageBox.Show("Tüm kelimeleri test ettiniz./nYanlış ve pas kelimelerinizin anlamlarına bakabilirsiniz.");
                            enabf();
                            temizledt();


                        }

                    }

                    else
                    { 
                      if (z2 < say2)
                    {
                        sonuckelime = Form2.tum3[s3].ToString();
                        bolünenkelime = sonuckelime.Substring(0, 4);
                        aranankelime = textBox1.Text.Substring(0, 4);

                        if (aranankelime == bolünenkelime)
                        {
                            dogru++;
                            label2_8.Text = dogru.ToString();
                            textBox1.Text = "";
                            label18.Text = "";
                            label20.Text = "";
                            textBox1.Text = "";
                            s3++;
                            z2++;
                            label5.Text = z2.ToString();
                            label18.Text = Form2.tum1[s3].ToString();
                            label20.Text = Form2.tum2[s3].ToString();

                        }

                        else
                        {
                            yanlıs++;
                            label2_10.Text = yanlıs.ToString();
                            textBox1.Text = "";
                            yant1.Add(Form2.tum1[s3].ToString());
                            yant2.Add(Form2.tum2[s3].ToString());
                            yant3.Add(Form2.tum3[s3].ToString());
                            s3++;
                            z2++;
                            label5.Text = z2.ToString();
                            label18.Text = Form2.tum1[s3].ToString();
                            label20.Text = Form2.tum2[s3].ToString();


                        }
                    }
                    else
                      {
                          yant1.Add(Form2.tum1[s3].ToString());
                          yant2.Add(Form2.tum2[s3].ToString());
                          yant3.Add(Form2.tum3[s3].ToString());
                          yanlıs++;
                          label2_10.Text = yanlıs.ToString();
                        MessageBox.Show("Tüm kelimeleri test ettiniz./nYanlış ve pas kelimelerinizin anlamlarına bakabilirsiniz.");
                        temizledt();
                        enabf();
                    }
                }
                    
                    

                }

                catch { };

            }

            else if (s2 != 0)

            {
                try
                {
                    if (comboBox1.Text == "Kaç kelime çalışmak istiyorsunuz?")
                    {
                        MessageBox.Show("Lütfen kaç kelime çalışmak istediğinizi seçiniz.");
                    }

                    else if (deg < say2)
                    {


                        kelime =ara();

                        {
                            // gelen değerlerin ekranda labellara yazdırdm

                            label18.Text = kelime;
                            label20.Text = tur;
                            
                            z2++;
                            label5.Text = z2.ToString();
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
                        enabf();
                        temizledt();
                        p2 = p1;
                        p1 = 0;
                        MessageBox.Show("Tüm kelimeleri test ettiniz./nYanlış ve pas kelimelerinizin anlamlarına bakabilirsiniz.");
                    }
                }

                catch
                { };

            }
               

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Kelimenin anlamı bölümüne herhangi bir giriş yapmadınız");
            else
            {
                try
                {
                    if (z2 < say2)
                    {
                        sonuckelime = Form2.tum3[s3].ToString();
                        bolünenkelime = sonuckelime.Substring(0, 4);
                        aranankelime = textBox1.Text.Substring(0, 4);

                        if (aranankelime == bolünenkelime)
                        {
                            dogru++;
                            label2_8.Text = dogru.ToString();
                            textBox1.Text = "";
                            label18.Text = "";
                            label20.Text = "";
                            textBox1.Text = "";
                            s3++;
                            z2++;
                            label5.Text = z2.ToString();
                            label18.Text = Form2.tum1[s3].ToString();
                            label20.Text = Form2.tum2[s3].ToString();

                        }

                        else
                        {
                            yanlıs++;
                            label2_10.Text = yanlıs.ToString();
                            textBox1.Text = "";
                            yant1.Add(Form2.tum1[s3].ToString());
                            yant2.Add(Form2.tum2[s3].ToString());
                            yant3.Add(Form2.tum3[s3].ToString());
                            s3++;
                            z2++;
                            label5.Text = z2.ToString();
                            label18.Text = Form2.tum1[s3].ToString();
                            label20.Text = Form2.tum2[s3].ToString();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Tüm kelimeleri test ettiniz./nYanlış ve pas kelimelerinizin anlamlarına bakabilirsiniz.");
                        temizledt();
                        enabf();
                    }
                }

                catch { };
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (z2 < say2)
                {
                    s5++;
                    label2_12.Text = s5.ToString();
                    label18.Text = "";
                    label20.Text = "";
                    textBox1.Text = "";

                    past1.Add(Form2.tum1[s3].ToString());
                    past2.Add(Form2.tum2[s3].ToString());
                    past3.Add(Form2.tum3[s3].ToString());
                    s3++;
                    z2++;
                    label5.Text = z2.ToString();
                    label18.Text = Form2.tum1[s3].ToString();
                    label20.Text = Form2.tum2[s3].ToString();
                }

                else
                {
                
                    MessageBox.Show("Tüm kelimeleri test ettiniz./nYanlış ve pas kelimelerinizin anlamlarına bakabilirsiniz.");
                    enabf();
                    temizledt();

                
                }
            }

            catch { };
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

      

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;

            say2 = Form2.say1;
            

            if (Form2.g1==0)
                checkBox1.Visible = false;
            else
                checkBox1.Visible = true;


            
            checkBox1.Checked = false;
            checkBox1.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            say2 = int.Parse(comboBox1.SelectedItem.ToString()); // Combobox içinden gelen değerin kodu.
            comboBox1.Visible = false;
            label5.Text =z2.ToString();
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

        private void button2_6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s9 < yanlıs)
                {
                    label2_14.Text = yant1[s9].ToString();
                    label2_16.Text = yant2[s9].ToString();
                    label2_18.Text = yant3[s9].ToString();
                    s9++;
                }

                else
                {
                    MessageBox.Show("Tüm yanlış kelimelerin anlamına baktınız.\nYanlış kelimelerin anlamlarına baştan bakabilirsiniz.");
                    temizleya();
                    s9 = 0;

                }
            }
            catch { };
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s8 < s5)
                {
                    label17.Text = past1[s8].ToString();
                    label24.Text = past2[s8].ToString();
                    label25.Text = past3[s8].ToString();
                    s8++;
                }

                else
                {
                    MessageBox.Show("Pas geçtiğiniz tüm kelimelerin anlamına baktınız.\nPas geçtiğiniz kelimelerin anlamlarına baştan bakabilirsiniz.");
                    temizlepa();
                    s8 = 0;

                }
                }

            catch { };
        
        }

        private void button2_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelime Sayısı="+Form2.say1+"\nDoğru Sayısı="+dogru+"\nYanlış Sayısı="+yanlıs+"\nPas Sayısı="+s5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
