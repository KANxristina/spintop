using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjectSpinTop
{
    public partial class Courses : Form
    {
        int NewID;
        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            textBox2.Text = StudentsIndex2.SetValuefromtextbox2;
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            string query = "Select  MAX(ID)   FROM Courses";
            SQLiteCommand cmd = new SQLiteCommand(query, cnn);
            cnn.Open();
            int getvalueID = Int32.Parse(cmd.ExecuteScalar().ToString());
            NewID = getvalueID + 1;
            textBox1.Text = NewID.ToString();
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            SQLiteCommand mycommand = new SQLiteCommand("Insert into Courses(ID,CourseName,CourseDescription) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "');");
            mycommand.Connection = cnn;
            cnn.Open();
            mycommand.ExecuteNonQuery();
            MessageBox.Show("Tο μάθημα καταχωρήθηκε");
            textBox1.Clear();
            textBox2.Clear();
            richTextBox1.Clear();
        }
    }
}
