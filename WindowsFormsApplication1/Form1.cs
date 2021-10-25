using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
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

        #region Metodlar

        public void formaç(Form x)
        {
            this.Hide();
            x.ShowDialog();
            this.Show();
        
        }

        #endregion

        #region Tanımlamalar

        public static Form2 frm2 = new Form2();
        public static Form3 frm3 = new Form3();
        public static Form4 frm4 = new Form4();

        #endregion

        public Form1()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 549, 381, 15, 15));
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaç(frm2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formaç(frm3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formaç(frm4);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kelimeÇalışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaç(frm2);
        }

        private void testEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaç(frm3);
        }

        private void kelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formaç(frm4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
