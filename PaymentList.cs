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
    public partial class PaymentList : Form
    {
        public PaymentList()
        {
            InitializeComponent();
        }

        private void PaymentList_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
