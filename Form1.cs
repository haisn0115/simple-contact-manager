using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Contact_Manager
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Name and phone number cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long dummy;
            if (!long.TryParse(phone, out dummy))
            {
                MessageBox.Show("Phone number must be numeric.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstDisplay.Items.Add(name + " - " + phone);

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic if needed
        }




        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key press
            }
           
        }
        // clear field
        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhone.Clear();
            
        }

        // delete fields
        private void button2_Click(object sender, EventArgs e)
        {
            if (lstDisplay.SelectedItem != null) lstDisplay.Items.Remove(lstDisplay.SelectedItem);
            else MessageBox.Show("Select a contact to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    


    }
}

        
    
    

