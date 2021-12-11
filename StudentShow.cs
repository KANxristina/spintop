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
    public partial class StudentShow : Form
    {
        int vaccinated;
        public static string stud_ID;
        public static string stud_FN;
        public static string stud_LN;

        int NewID;
        public StudentShow()
        {
            InitializeComponent();
        }

        private void StudentShow_Load(object sender, EventArgs e)
        {
            textBox2.Text = StudentsIndex2.SetValuefromtextbox2;
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            textBox1.Text = StudentsIndex2.student_ID;
            textBox2.Text = StudentsIndex2.student_FN;
            textBox3.Text = StudentsIndex2.student_LN;
            textBox4.Text = StudentsIndex2.student_Address;
            textBox5.Text = StudentsIndex2.student_phone1;
            textBox6.Text = StudentsIndex2.student_phone2;
            textBox7.Text = StudentsIndex2.student_email;
            maskedTextBox1.Text = StudentsIndex2.student_birthday;
           // maskedTextBox2.Text = StudentsIndex2.student_date;
            textBox1.Enabled = false;



            if (radioButton1.Checked)
            {
                vaccinated = 1;
            }
            else if (radioButton2.Checked)
            {
                vaccinated = 0;
            }
            //else
            // {
            //   vaccinated = 0;
            // }
            stud_ID = Convert.ToString(textBox1.Text);
            stud_FN = Convert.ToString(textBox2.Text);
            stud_LN = Convert.ToString(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            SQLiteCommand mycommand = new SQLiteCommand("Insert into Students(ID,firstname,lastname,Address,phonenumber1,phonenumber2,email,birthday,date,vaccinared) Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + vaccinated + "');");
            mycommand.Connection = cnn;
            cnn.Open();
            mycommand.ExecuteNonQuery();
            MessageBox.Show("Ο μαθητής καταχωρήθηκε");
            textBox1.Clear();
            NewID = NewID + 1;
            textBox1.Text = NewID.ToString();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string string1 = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος ότι θέλετε να αποχωρήσετε;", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                StudentsIndex2 studentindex = new StudentsIndex2();
                studentindex.Show();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void cREATEPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void νΕΑΠΛΗΡΩΜΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment= new Payment();
            payment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            string query = "Select * from Payment ";
            cnn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = data;
        }
    }
}
