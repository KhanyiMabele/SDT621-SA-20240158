// 1.2 Write the events for each button 
// 1.2.1 When the btnAdd button is clicked, the program should insert a record into the tblMobilePhones with the MobileCode, Make and Quantity from the corresponding data from the form and and display the message “Record Added” in the lblOutput. (8) 
// 1.2.2 When the btnDelete button is clicked, the program should delete the record whose MobileCode is typed in the txtCode text field and display the message “Record Found” in the lblOutput; or “Record NOT Found” if the record is not found. (7)
// 1.2.3 When the btnFind is clicked, the program should find the record whose  
// MobileCode is typed in the txtCode text field and display the message “Record Deleted” in the lblOutput. (5)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Stock_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
            view records();
            tblMobilePhones mobile = new tblMobilePhones();
             mobile.MobileCode = txtCode.Text;
             mobile.Make = txtMake.Text;
             mobile.Quantity = int.Parse(txtQuantify.Text);
            lblOutput.Text = "Record Added";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          deleteRecord();
          lblOutput.Text = "Record Deleted";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
         findRecord();
         lblOutput.Text = "Record Found";

        }
    }
}