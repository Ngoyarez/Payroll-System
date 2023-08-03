using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSytem
{
   
    public partial class Form1 : Form
    {
        private int flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = 0;
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100 && flag == 0)
            {
                Main fm = new Main();
                fm.Visible = true;
                this.Hide();
                flag = 1;
            }
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 100;
                lblProgress.Text = "Progress..." + progressBar1.Value + "%";
            }
            if (progressBar1.Value == 100)
            {
                lblProgress.Text = "Completed";
            }
        }

        

       
       
      
    }
}
