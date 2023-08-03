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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        public void enable_menu()
        {
            tsLogin.Text = "Logout";
            tsLogin.Image = PayrollSytem.Properties.Resources._lock;
            tsEmployee.Enabled = true;
            tsPayroll.Enabled = true;
            tsUser.Enabled = true;
          

        }
         
        private void closeChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Employees());
        }

        private void tsPayroll_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_Payroll());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            closeChildForm();
            showFrm(new frm_user());
        }

        
        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (tsLogin.Text == "Login")
            {
                closeChildForm();
                showFrm(new frm_login(this));
            }
            else
            {
                tsLogin.Text = "Login";
                tsLogin.Image = PayrollSytem.Properties.Resources._lock;
                tsEmployee.Enabled = false;
                tsPayroll.Enabled = false;
                tsUser.Enabled = false;
               
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.MdiParent = this;
            f.Visible = true;

          
        }

        
      

              

    }
}
