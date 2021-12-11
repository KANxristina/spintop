using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSpinTop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses courses = new Courses();
            courses.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsIndex2 studentindex2 = new StudentsIndex2();
            studentindex2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersIndex teacherindex = new TeachersIndex();
            teacherindex.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers teachers = new Teachers();
            teachers.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος;", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                

            }
            else if (dialogResult == DialogResult.No)
            {

            }
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentList paymentlist = new PaymentList();
            paymentlist.Show();
        }

        private void κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void νΕΟΣΜΑΘΗΤΗΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student student = new Student();
            student.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος;", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();


            }
            else if (dialogResult == DialogResult.No)
            {

            }
          
        }

        private void αλλαγήUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος;", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void νΕΟΜΑΘΗΜΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses course = new Courses();
            course.Show();
        }

        private void εΥΡΜΑΘΗΜΑΤΩΝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void νΕΟΣΔΑΣΚΑΛΟΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teachers teacher = new Teachers();
            teacher.Show();
        }

        private void εΥΡΔΑΣΚΑΛΩΝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersIndex teacherindex = new TeachersIndex();
            teacherindex.Show();
        }
    }
}
