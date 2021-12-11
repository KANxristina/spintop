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
    public partial class Student : Form
    {
        
         int vaccinated;
        

        int NewID;
        public Student()
        {
            InitializeComponent();
           
        }

       
        
        

        private void Student_Load(object sender, EventArgs e)
        {
            textBox2.Text = StudentsIndex2.SetValuefromtextbox2;
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            
                string query = "Select  MAX(ID)   FROM Students";
                SQLiteCommand cmd = new SQLiteCommand(query, cnn);
                cnn.Open();
                int getvalueID = Int32.Parse(cmd.ExecuteScalar().ToString());
                NewID = getvalueID + 1;
                textBox1.Text = NewID.ToString();
          

            textBox1.Enabled = false;
            

            
            if (radioButton1.Checked)
            {
                vaccinated = 1;
            }
            else if(radioButton2.Checked)
            {
                  vaccinated=0;
            }
            //else
            // {
            //   vaccinated = 0;
            // }
            

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
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος ότι θέλετε να αποχωρήσετε;","EXIT",MessageBoxButtons.YesNo);
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

        private void δΗΜΙΟΥΡΓΙΑPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
