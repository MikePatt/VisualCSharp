using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWinApp2
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

      
        private void accptButton_Click(object sender, EventArgs e)
        {
            Person myPerson = new Person(txtFirstName.Text, txtLastName.Text);

            lblResult.Text = ($"Your Name is {myPerson.FirstName} { myPerson.LastName}!");
        }
    }
}
