using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Data;

namespace ProjectSpinTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            cnn.Open();
            string query = "Select * from User where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
            SQLiteDataAdapter sda = new SQLiteDataAdapter(query, cnn);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            if (dt.Tables[0].Rows.Count==1)
            {
                this.Hide();
                Main mainpage = new Main();
                mainpage.Show();
            }
            else
            {
                MessageBox.Show("error");
            }

            // SQLiteCommand sqlite_cmd= new SQLiteCommand(query);
            // SQLiteCommand sqlite_cmd;
            //sqlite_cmd = cnn.CreateCommand();
            //cnn.Open();
            //sqlite_cmd = CreateCommand(query);
            //sqlite_cmd.Connection.Open();
            //sqlite_cmd.ExecuteNonQuery();
        }
    }
}
