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

namespace ProjectSpinTop
{
    public partial class StudentsIndex2 : Form
    {
        public static string SetValuefromtextbox2 = "";
        public static string student_ID = "";
        public static string student_FN = "";
        public static string student_LN = "";
        public static string student_Address = "";
        public static string student_phone1 = "";
        public static string student_phone2 = "";
        public static string student_email = "";
        public static string student_birthday = "";
        public static string student_date = "";
        public static string student_vaccinated = "";

        public StudentsIndex2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            string query = "Select * from Students ";
            cnn.Open();

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, cnn);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = data;

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
     
            
           
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   string con_string = "C:/Users/Kanaki/source/repos/ProjectSpinTop/ProjectSpinTop/bin/ProjectDatabase.db";
            SQLiteConnection cnn = new SQLiteConnection("Data Source=" + con_string + ";Version=3;");
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            student_ID =row.Cells["ID"].Value.ToString();
            student_FN=row.Cells["firstname"].Value.ToString();
            student_LN = row.Cells["lastname"].Value.ToString();
            student_Address = row.Cells["Address"].Value.ToString();
            student_phone1 = row.Cells["phonenumber1"].Value.ToString();
            student_phone2 = row.Cells["phonenumber2"].Value.ToString();
            student_email = row.Cells["email"].Value.ToString();
            student_birthday = row.Cells["birthday"].Value.ToString();
            //student_date = row.Cells["date"].Value.ToString();
            string query = "Select  ID="+ student_ID +"FROM Students";
            
            SQLiteCommand cmd = new SQLiteCommand(query, cnn);
            cnn.Open();
            StudentShow studentshow = new StudentShow();
            this.Hide();
            studentshow.Show();



        }

        private void StudentsIndex2_Load(object sender, EventArgs e)
        {

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

        private void κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void contextMenuStrip1(object sender, EventArgs e)
        {

        }

        private void κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
