using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriForm
{
    public partial class Form1 : Form
    {
        public string ConnectString { private get; set; }
        public Form1()
        {
            ConnectString =
               "Server = (localdb)\\MSSQLLocalDB; " +
               "Database = keksz; ";
            //Véletlen elírtam az db nevét.
            InitializeComponent();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dgv_load();
        }

        private void Dgv_load()
        {
            DGV.Rows.Clear();

            using (var c = new SqlConnection(ConnectString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT id, db, iz " +
                    "FROM gyori ;", c).ExecuteReader();

                while (r.Read())
                {
                    DGV.Rows.Add(r[0], r[1], r[2]);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
