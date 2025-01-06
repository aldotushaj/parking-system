using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotManagementSystem
{
    public partial class Form1 : Form
    {
        string a;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBut_Click(object sender, EventArgs e) // Login Button
        {
            string user = usernameTB.Text;
            string pass = passwordTB.Text;

            /// Set the Accounts username and password
            string username = "admin";
            string password = "1234";

            /// Displays an error message when the attendant is not selected
            if (attendantCB.SelectedItem != null) 
            {
                string attendantName = attendantCB.SelectedItem.ToString();
                    
                    /// Opens "Form2" when user and pass is verified
                    if (user == username && pass == password)
                    {
                        this.Hide();

                        /// Data from the combo box is passed to Form2
                        a = attendantName;
                        Form2 frm = new Form2();
                        frm.ab(a.ToString());
                        frm.Show(); 

                    }
                    else
                    {
                        MessageBox.Show("Login Failed.", "Error");
                    }
            }
            else
            {
                MessageBox.Show("Please select the Attendant.", "Error");
            }
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void attendantCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
