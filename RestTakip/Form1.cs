using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
            string kullanici_adi = "1";
            string sifre = "2";
    

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAd.Focus();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == kullanici_adi && txtPw.Text == sifre)
            {
              
              /*  dashboards newform = new dashboards();
                newform.ShowDialog();
                this.Close();*/
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
