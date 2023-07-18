using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
            double tax, salary, pureSalary;
            try
            {
                salary = Convert.ToDouble(txtSalary.Text);

                if (salary < 50_000)
                {
                    tax = 0;
                }
                else if (salary < 100_000)
                {
                    tax = 5 * salary / 100;
                }
                else if (salary < 200_000)
                {
                    tax = 10 * salary / 100;
                }
                else if (salary < 3_000_000)
                {
                    tax = 15 * salary / 100;
                }
                else
                {
                    tax = 15 * salary / 100;
                }

                pureSalary = salary - tax;

                lblResult.Text = txtName.Text + " your tax is: " + tax.ToString() + "\n your payment is: " + pureSalary.ToString();
                txtName.Focus();
                txtName.SelectAll();

            }
            catch
            {
                lblResult.Text = "Please Enter Valid input! ";
                txtSalary.Focus();
                txtSalary.SelectAll();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirm =  MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitConfirm == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSalary.Text = "";
            lblResult.Text = " ";
            txtName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"\t      Salary  <  50_000 => tax = 0 " +
                            $"\n\n    50_000 < Salary < 100_000  => tax = 5 * salary / 100 " +
                            $"\n\n   100_000 < salary < 200_000  => tax = 10 * salary / 100  " +
                            $"\n\n   200_000 < salary < 3_000_000=> tax = 15 * salary / 100   " +
                            $"\n\n\t      Salary > 3_000_000=> tax = 15 * salary / 100 ");
        }

        private void frmTaxCalculator_Load(object sender, EventArgs e)
        {

            txtName_TextChanged(null, null);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                btnCalculate.Enabled = false;
            }
            else
            {
                btnCalculate.Enabled = true;
            }
        }
    }
}
