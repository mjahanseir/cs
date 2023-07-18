using MyContact.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace MyContact
{
    public partial class frmAddOrEdit : Form
    {
        IRepository repository;
        public int contactID = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactID == 0)
            {
                this.Text = "Add new Contact";
            }
            else
            {
                this.Text = "Edit Contact";
                DataTable dt=repository.SelectRow(contactID);

                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtMobile.Text = dt.Rows[0][3].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                txtAge.Text = dt.Rows[0][5].ToString();
                txtAddress.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "Edit";

            }
        }
        bool ValidateInputs()
        {
            bool isValid = true;


            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter First Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
               
            if (txtFamily.Text == "")
            {
                MessageBox.Show("Please Enter Last Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                          
             
            if (txtAge.Value ==0)
            {
                MessageBox.Show("Please Enter Age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                       
            if (txtMobile.Text =="")
            {
                MessageBox.Show("Please Enter Mobile Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                bool isSuccess;
                if (contactID == 0)
                {
                    isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(contactID, txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value, txtAddress.Text);
                }

                if( isSuccess==true)
                {
                    MessageBox.Show("Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Failed!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
