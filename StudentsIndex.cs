using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
//using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
//using Devart.Data.SQLite.SQLiteDataAdapter;

namespace ProjectSpinTop
{
    public partial class StudentsIndex : Form
    {
        public StudentsIndex()
        {
            InitializeComponent();
            
           dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            

        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            string query = "Select * from Students ";
            cnn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cnn);
            DataTable data = new DataTable();
            //DataSet ds = new DataSet();
            da.Fill(data);
            dataGridView1.DataSource = data;
            

            
            cnn.Close();
        }

        private void StudentsIndex_Load(object sender, EventArgs e)
        {

        }
    }
    
}
