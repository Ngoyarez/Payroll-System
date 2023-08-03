using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSytem.Includes;


namespace PayrollSytem
{
    public partial class frm_Employees : Form
    {
        public frm_Employees()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        string rdo;
        private void btnempsave_Click(object sender, EventArgs e)
        {

            if (txtEmployeeCode.Text == "" || txtFirstName.Text== "" || txtLastName.Text == "" || txtMiddleName.Text == "" 
                || txtAddress.Text == "" || txtContact.Text == "" || txtStatus.Text == "" || txtBirthPlace.Text == "" 
                || txtAge.Text == "" || txtEmergeContact.Text == "" || txtDailyRate.Text == "" || txtPosition.Text == "" )
            {
                MessageBox.Show("Please fill all the Details. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(radioMale.Checked)
                {
                    rdo = "Male";
                }
                else
                {
                    rdo = "Female";
                }
                sql = "INSERT INTO `employee_workinfo` (`emp_code`, `daily_rate`, `pay_method`, `position`, `work_status`, `date_hired`)" 
                        + " VALUES ('" + txtEmployeeCode.Text + "','" + txtDailyRate.Text + "','" + txtPayMethod.Text + "','" + txtPosition.Text 
                        + "','" + txtworkstatus.Text + "','" + dtDateHired.Text + "')";
                config.Execute_Query(sql);

                sql = "INSERT INTO `employee` (`emp_code`, `emp_fname`, `emp_lname`, `emp_mname`" 
                   + ", `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`"
                   + ", `emerg_contact`) VALUES ('" + txtEmployeeCode.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text
                   + "','" + txtMiddleName.Text + "','" + txtAddress.Text + "'," + txtContact.Text + ",'" + txtStatus.Text
                   + "','" + dtBirth.Text + "','" + txtBirthPlace.Text + "','" + rdo + "'," + txtAge.Text + ",'" + txtContact.Text + "')";
                config.Execute_CUD(sql, "Error to execute.", "Data has been saved in the database.");
                btnempnew_Click(sender, e);
            }
             
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew  WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" + txtEmployeeCode.Text + "'";
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                txtDailyRate.Text = config.dt.Rows[0].Field<int>("daily_rate").ToString();
                txtPayMethod.Text = config.dt.Rows[0].Field<string>("pay_method").ToString();
                txtPosition.Text = config.dt.Rows[0].Field<string>("position").ToString();
                txtworkstatus.Text = config.dt.Rows[0].Field<string>("work_status").ToString();
                dtDateHired.Text = config.dt.Rows[0].Field<DateTime>("date_hired").ToString();

                txtFirstName.Text = config.dt.Rows[0].Field<string>("emp_fname").ToString();
                txtLastName.Text = config.dt.Rows[0].Field<string>("emp_lname").ToString();
                txtMiddleName.Text = config.dt.Rows[0].Field<string>("emp_mname").ToString();
                txtAddress.Text = config.dt.Rows[0].Field<string>("address").ToString();
                txtContact.Text = config.dt.Rows[0].Field<string>("contact").ToString();
                txtStatus.Text = config.dt.Rows[0].Field<string>("status").ToString();
                dtBirth.Text = config.dt.Rows[0].Field<DateTime>("birth_date").ToString();
                txtBirthPlace.Text = config.dt.Rows[0].Field<string>("birth_place").ToString();

                if (config.dt.Rows[0].Field<string>("emp_sex").ToString() == "Male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;

                }

                txtAge.Text = config.dt.Rows[0].Field<int>("emp_age").ToString();
                txtContact.Text = config.dt.Rows[0].Field<string>("emerg_contact").ToString();

                btnempsave.Enabled = false;
                btnempupdate.Enabled = true;

            }
            else
            {
                funct.clearTxt(GroupBox10);
                funct.clearTxt(GroupBox9);
                btnempsave.Enabled = true;
                btnempupdate.Enabled = false;
            }
            
        }

        private void btnempnew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(GroupBox10);
            funct.clearTxt(GroupBox9);

            btnempsave.Enabled = true;
            btnempupdate.Enabled = false;
            txtEmployeeCode.Clear();

            list_Employee();
            funct.ResponsiveDtg(dtgemplist);
        }

        private void btnempupdate_Click(object sender, EventArgs e)

        {
            if (txtEmployeeCode.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == ""
              || txtAddress.Text == "" || txtContact.Text == "" || txtStatus.Text == "" || txtBirthPlace.Text == ""
              || txtAge.Text == "" || txtEmergeContact.Text == "" || txtDailyRate.Text == "" || txtPosition.Text == "")
            {
                MessageBox.Show("One of the box is empty. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (radioMale.Checked)
                {
                    rdo = "Male";
                }
                else
                {
                    rdo = "Female";
                }

                sql = "UPDATE `employee_workinfo` SET  `daily_rate`='" + txtDailyRate.Text 
                  + "', `pay_method`='" + txtPayMethod.Text + "', `position`='" + txtPosition.Text
                  + "', `work_status`='" + txtworkstatus.Text + "', `date_hired`='" + dtDateHired.Text + "' WHERE `emp_code`='" + txtEmployeeCode.Text + "'";
                config.Execute_Query(sql);

                sql = "UPDATE `employee` SET  `emp_fname`='" + txtFirstName.Text 
                + "', `emp_lname`='" + txtLastName.Text + "', `emp_mname`='" + txtMiddleName.Text 
                + "', `address`='" + txtAddress.Text + "', `contact`='" + txtContact.Text + "', `status`='" + txtStatus.Text 
                + "', `birth_date`='" + dtBirth.Text + "', `birth_place`='" + txtBirthPlace.Text + "', `emp_sex`='" + rdo 
                + "', `emp_age`='" + txtAge.Text + "', `emerg_contact`='" + txtContact.Text 
                + "' WHERE `emp_code`='" + txtEmployeeCode.Text + "'";
                config.Execute_CUD(sql, "Error to execute.", "Data has been updated in the database.");
                //btnempnew_Click(sender, e);

            }
        }

        private void list_Employee()
        {
            sql = "SELECT `emp_code` AS 'CODE',CONCAT( `emp_fname`,' ', `emp_lname`,' ', `emp_mname`) AS 'NAME'" 
             + ", `emp_age` AS 'AGE', `emp_sex` AS 'GENDER', `status` AS 'STATUS', `address` AS 'ADDRESS'" 
             + ", `contact` AS 'CONTACT'  FROM `employee` WHERE `emp_code` LIKE '%" + txtempsearch.Text + "%'" 
             + " OR emp_fname LIKE '%" + txtempsearch.Text  + "%' OR emp_lname LIKE '%" + txtempsearch.Text + "%'";
            config.Load_DTG(sql, dtgemplist);
        }

        private void frm_Employees_Load(object sender, EventArgs e)
        {
            btnempnew_Click(sender, e);
        }

        private void txtempsearch_TextChanged(object sender, EventArgs e)
        {
            list_Employee();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM employee WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM employee_workinfo  WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            sql = "DELETE FROM deductions WHERE emp_code = '" + dtgemplist.CurrentRow.Cells[0].Value.ToString() + "'";
            config.Execute_Query(sql);

            MessageBox.Show("Employee has been deleted.", "Delete",MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnempnew_Click(sender, e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txtEmployeeCode.Text = dtgemplist.CurrentRow.Cells[0].Value.ToString();
            TabControl2.SelectedTab = TabPage6;
            btnempsave.Enabled = false;
            btnempupdate.Enabled = true;


        }
    }
}
