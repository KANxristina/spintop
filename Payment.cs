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
    public partial class Payment : Form
    {
        int NewID;
        public Payment()
        {
            InitializeComponent();
        }

        private void PaymentListPerStudent_Load(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");

            string query = "Select  MAX(ID)   FROM Payment";
            SQLiteCommand cmd = new SQLiteCommand(query, cnn);
            cnn.Open();
            int getvalueID = Int32.Parse(cmd.ExecuteScalar().ToString());
            NewID = getvalueID + 1;
            textBox1.Text = NewID.ToString();
            textBox5.Text = StudentShow.stud_ID;
            textBox2.Text = StudentShow.stud_FN;
            textBox3.Text = StudentShow.stud_LN;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            SQLiteCommand mycommand = new SQLiteCommand("Insert into Payment(ID,StudentID,Firstname,Lastname,Value,PaymentDate) Values('" + textBox1.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," +
                                                 "'" + textBox4.Text + "','" + maskedTextBox1.Text + "');");
            mycommand.Connection = cnn;
            cnn.Open();
            mycommand.ExecuteNonQuery();
            MessageBox.Show("Καταχωρήθηκε");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            maskedTextBox1.Clear();
            
           
        }
    }
}
