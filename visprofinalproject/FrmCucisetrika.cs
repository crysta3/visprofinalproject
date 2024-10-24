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
    public partial class FrmCucisetrika : Form
    {
        public FrmCucisetrika()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCustom1 frmCustom1 = new FrmCustom1();
            frmCustom1.Show();
            this.Hide();
        }
    }
}
