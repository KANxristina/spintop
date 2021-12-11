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
//using Microsoft.Data.Sqlite;
using System.Data.SQLite;


namespace ProjectSpinTop
{
    public partial class TeachersIndex : Form
    {
        public SQLiteConnection cnn;
        //public SQLiteCommand cmd;
        public TeachersIndex()
        {
            InitializeComponent();
           // GenerateDatabase();
        }
        public void TeachersIndex_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            cnn.Open();
            string query = "Select * from Teachers ";
            SQLiteCommand cmd = new SQLiteCommand(query,cnn);           
            cmd.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable data1 = new DataTable();
            da.Fill(data1);
            SQLiteDataReader dreader;
            dreader = cmd.ExecuteReader();
           
            //    foreach (DataRow dr in data1.Rows)
           //{
            //    comboBox1.Items.Add(dr["TeacherFirstName"].ToString());
           // }
            while (dreader.Read())
            {
                 comboBox1.Items.Add(dreader["TeacherFirstName"]);
                
            }
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            string query = "Select * from Teachers ";
            cnn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος ότι θέλετε να αποχωρήσετε;", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
