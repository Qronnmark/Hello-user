using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmHello : Form
    {
        private static string username;
        private static int userage;
        private static string userFeeling;

        public frmHello()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnEntertheMatrix_Click(object sender, EventArgs e)
        {
            lblMatrix.Text = "Hello, (User). Please enter your name in the box below.";
        }
       
        private void frmHello_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = txtName.Text;
            lblnameResponse.Text = "Hello " + username + "! What is your age?";
        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {
            userage = Convert.ToInt32( txtage.Text);
            lblAgeResponse.Text = "So, you are " + userage + ". How are you feeling?";

        }

        private void txtFeeling_TextChanged(object sender, EventArgs e)
        {
            userFeeling = txtFeeling.Text;
            lblFinalResponse.Text = "So, altogether you are " + userFeeling + ", your name is " + username + ", and you are " + userage + ". Cool.";
        }
    }
}
