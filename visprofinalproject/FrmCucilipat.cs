using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visprofinalproject
{
    public partial class FrmCucilipat : Form
    {
        public FrmCucilipat()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCustom1 frmCustom1 = new FrmCustom1();
            frmCustom1.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCucilipat_Load(object sender, EventArgs e)
        {

        }
    }
}
