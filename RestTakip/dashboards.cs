using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.ConnectionParameters;

namespace RestTakip
{
    public partial class dashboards : Form
    {
        public dashboards()
        {
            InitializeComponent();

        }
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString="server=127.0.0.1;uid=root;pwd=sql123;database=los_amigos;";

        static string tablo = "";

        private void cariToplamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\fatura_baslik_1";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");

        }
        private void stokAdediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\fatura_detay1";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
            
        }

        private void stokToplamFiyatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\fatura_detay2";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
           
        }

        private void masaToplamFiyatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\genhar_1";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
            
        }

        private void garsonToplamÇikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\genhar_2";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");

        }

        private void stokToplamPorsiyonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\stokhar_2";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
            
        }

        private void grupToplamÇikisFiyatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\stokhar_3";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");

        }

        private void toplamStokMiktariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\uretimhar_2";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
          
        }
        private void dashboards_Load(object sender, EventArgs e)
        {
            

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Veritabanı Bağlantı Hatası",ex.Message);
            }
        }

        private void dashboardViewer1_DataLoading(object sender, DevExpress.DataAccess.DataLoadingEventArgs e)
        {
            
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DataAccess.ConfigureDataConnectionEventArgs e)
        {
            if (e.ConnectionName == "localhost_los_amigosConnection")
            {

                // Gets the connection parameters used to establish a connection to the database.
                MySqlConnectionParameters parameters =
                    (MySqlConnectionParameters)e.ConnectionParameters;

                // Specifies the user name used to access the database file. 
                parameters.UserName = "root";

                // Specifies the password used to access the database file.
                parameters.Password = "sql123";
            }
        }


        private void rbPie_Click_1(object sender, EventArgs e)
        {
            rbPie.Checked = true;

            dashboardViewer1.LoadDashboard(tablo + "p.xml");
        }

        private void rbChart_Click(object sender, EventArgs e)
        {
            rbChart.Checked = true;

            dashboardViewer1.LoadDashboard(tablo + "c.xml");
        }

        private void stokToplamÇıkışFiyatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\stokhar_1";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
        }

        private void toplamHammaddeMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablo = @"C:\Users\Melis\Documents\Visual Studio 2012\Projects\RestTakip\dash_XML\uretimhar_1";
            rbChart.Checked = true;
            dashboardViewer1.LoadDashboard(tablo + "c.xml");
        }

        private void dashboards_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
    }
}
