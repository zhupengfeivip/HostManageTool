using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostManageTool
{
    public partial class FrmNoReg : Form
    {
        public FrmNoReg()
        {
            InitializeComponent();
        }

        private int sec = 30;

        private void FrmNoReg_Load(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            btnClose.Text = sec.ToString();
            if (sec <= 0)
            {
                timer1.Enabled = false;
                btnClose.Enabled = true;
                btnClose.Text = "不注册(&C)";
                return;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmReg reg = new FrmReg();
            reg.ShowDialog(this);
        }
    }
}
