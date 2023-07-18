using MyContact.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class Form1 : Form
    {
        IRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();

        }

        private void BindGrid()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = repository.SelectAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                if (dgContacts.CurrentRow != null)
                {
                    string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
                    string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
                    string fullName = name + " " + family;
                    if (MessageBox.Show($"Are you sure to Delete {fullName}?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                        repository.Delete(contactId);
                        BindGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Contact");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgContacts.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.contactID = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
