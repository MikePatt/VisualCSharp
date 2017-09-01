using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string oldLblResult = string.Empty;
            int counter = 1;

            while(counter <= 10)
            {
                oldLblResult = lblResult.Text;
                lblResult.Text = $"{oldLblResult}This is number: {counter}\n";
                counter++;
            }
        }
    }
}
