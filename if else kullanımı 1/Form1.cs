using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_kullanımı_1
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

        private void btnRenk_Click(object sender, EventArgs e)
        {
            if (cbMavi.Checked == true) 
            {
                lblYaz.Text = "Mavi yapıldı.";
                BackColor = Color.CornflowerBlue;
            }
            else
            {
                lblYaz.Text = "Mavi kaldırıldı.";
                BackColor = Color.White;
            }
        }
    }
}
