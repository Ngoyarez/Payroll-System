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
    public partial class frm_Payroll : Form
    {
        public frm_Payroll()
        {
            InitializeComponent();
        }


        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void calc_on_deduction()
        {
            try
            {
               double nhif, nssf, loan, total_deduction, gross, net_income;

               nhif = double.Parse(txtNHIF.Text);
               nssf = double.Parse(txtNSSF.Text);
               loan = double.Parse(txtLoan.Text);
               gross = double.Parse(txtGrossIncome.Text);

               total_deduction = nhif + nssf + loan;
               txtTotalDeduction.Text = total_deduction.ToString();

               net_income = gross - total_deduction;
               txtNetIncome.Text = net_income.ToString();
            }
            catch(Exception e)
            {
                
            }
           
        }

        private void load_data()
        {
            sql = "SELECT DISTINCT (" +
             "p.`trans_id`" +
             "),e.emp_code as 'Employee Code', CONCAT(  `emp_fname` ,  ' ',  `emp_lname` ,  ' ',  `emp_mname` ) AS  'Employee'" +
             ",  `daily_rate` AS 'Daily Rate' ,  `num_days` AS 'Number Of Days' ,  `rate_wage` AS 'Rate Wage', "
             + " `gross_salary` AS 'Gross Income', `total_deduct` AS 'Total Deduction',  `net_income` AS 'Net Income' ,  " +
             " `position` AS 'Postion',`remarks` AS 'Remarks' ,`dateissued` AS 'Date Issued'    " +
             "FROM  `employee` e,  `payroll` p,  `employee_workinfo` ew,  `deductions` d " +
             "WHERE e.`emp_code` = p.`emp_code` " +
             "AND p.`emp_code` = ew.`emp_code` " +
             "AND p.`trans_id` = d.`trans_id` " +
             "AND  (emp_fname  LIKE '%" + txtpsearch.Text + "%'" +
             "OR  emp_lname  LIKE '%" + txtpsearch.Text + "%'" +
             "OR e.emp_code LIKE '%" + txtpsearch.Text + "%')";
            config.Load_DTG(sql, dtgParollList);
            dtgParollList.Columns[0].Visible = false;
            funct.ResponsiveDtg(dtgParollList);


            sql = "SELECT concat(autoname,strnum) as auto FROM autonumber WHERE id = 1";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txttranscode.Text = config.dt.Rows[0].Field<string>("auto");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
            txtRemarks.Text = "";
            txtEmployeeCode.Text = "";
            funct.clearTxt(GroupBox3);
            funct.clearTxt(GroupBox4);
            funct.clearTxt(GroupBox5);
            txtRateWage.Text = "0";
            txtGrossIncome.Text = "0";
            txtNetIncome.Text = "0";
            txtTotalDeduction.Text = "0";
            txtNHIF.Text = "0";
            txtNSSF.Text = "0";
            txtLoan.Text = "0";
            


        }

        private void frm_Payroll_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void txtEmployeeCode_TextChanged_1(object sender, EventArgs e)
        { 
            sql = "SELECT * FROM `employee` e, `employee_workinfo` ew " 
                + " WHERE e.`emp_code`=ew.`emp_code` AND e.emp_code ='" + txtEmployeeCode.Text + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtRatePerDay.Text = config.dt.Rows[0].Field<int>("daily_rate").ToString();
                txtPayMethod.Text = config.dt.Rows[0].Field<string>("pay_method").ToString();
                txtEmployeeName.Text = config.dt.Rows[0].Field<string>("emp_fname").ToString()
                + " " + config.dt.Rows[0].Field<string>("emp_lname").ToString() + " " 
                + config.dt.Rows[0].Field<string>("emp_mname").ToString();
            }
            else
            {
                txtEmployeeName.Text = "";
                txtRemarks.Text = ""; 
                funct.clearTxt(GroupBox3);
                funct.clearTxt(GroupBox4);
                funct.clearTxt(GroupBox5);
                txtRateWage.Text = "0";
                txtGrossIncome.Text = "0";
                txtNetIncome.Text = "0";
                txtTotalDeduction.Text = "0";
            }
             
        }

        private void txtNumDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rateWage, grossincome, neticome;

                if (txtNumDays.Text == "" || txtNumDays.Text == "0")
                {
                    txtRateWage.Text = "0";
                    rateWage = double.Parse(txtRateWage.Text);

                }
                else
                {
                    rateWage = double.Parse(txtRatePerDay.Text) * double.Parse(txtNumDays.Text);
                    txtRateWage.Text = rateWage.ToString();

                }

                grossincome = rateWage;
                txtGrossIncome.Text = grossincome.ToString();


                neticome = grossincome - double.Parse(txtTotalDeduction.Text);
                txtNetIncome.Text = neticome.ToString();
            }
            catch (Exception ex)
            {
              
            } 
        }

       

        private void txtNHIF_TextChanged(object sender, EventArgs e)
        {
          if(txtNHIF.Text == "" || txtNHIF.Text == "0")
            {
                txtNHIF.Text = "0";

            }

            calc_on_deduction();
        }

        private void txtNSSF_TextChanged(object sender, EventArgs e)
        {
            if (txtNSSF.Text == "" || txtNSSF.Text == "0")
            {
                txtNSSF.Text = "0";

            }
            calc_on_deduction();
        }

        private void txtLoan_TextChanged(object sender, EventArgs e)

        {
            if (txtLoan.Text == "" || txtLoan.Text == "0")
            {
                txtLoan.Text = "0";

            }
            calc_on_deduction();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtNumDays.Text == "" || txtNumDays.Text == "0")
            {
                MessageBox.Show("Please fill all details. Data is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "INSERT INTO `deductions` " 
                               + "(`emp_code`, `nhif_deduct`,`nssf_deduct`, `loan_deduct`, "
                               + "`total_deduct`,trans_id)"
                               + " VALUES ('" + txtEmployeeCode.Text + "','" + txtNHIF.Text + "','"
                               + txtNSSF.Text + "','" + txtLoan.Text + "','" 
                               + "','" + txtTotalDeduction.Text + "','" + txttranscode.Text + "')";
                config.Execute_Query(sql);

                sql = "INSERT INTO  `payroll` " 
                    + "(`emp_code`, `num_days`, `rate_wage`, `gross_salary`" 
                    + ",`net_income`, `remarks`,`dateissued`,trans_id)" 
                    + " VALUES ('" + txtEmployeeCode.Text + "','" + txtNumDays.Text + "','" 
                    + txtRateWage.Text + "','" + txtGrossIncome.Text + "','" + txtNetIncome.Text 
                    + "','" + txtRemarks.Text + "',Now(),'" + txttranscode.Text + "')";

                config.Execute_Query(sql);

                MessageBox.Show("Data has been saved in the database.");

                config.Execute_Query("UPDATE autonumber SET strnum = strnum + increment WHERE id =1");
                txtEmployeeCode.Text = "";

                load_data();


            }
           
        }

        private void txtpsearch_TextChanged(object sender, EventArgs e)
        {
            load_data();
        }

       

       

        
   }
}
