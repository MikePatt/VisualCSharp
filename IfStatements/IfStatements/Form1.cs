using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boxer myBoxer = new Boxer(tbxName.Text, int.Parse(tbxPunch.Text));
            lblBoxName.Visible = true;
            lblPowEval.Visible = true;
            tbxBoxName.Visible = true;
            tbxPowEval.Visible = true;
            tbxBoxName.Text = $"{myBoxer.Name}";
            tbxPowEval.Text = $"{myBoxer.PunchSpeedEval}";

        }
    }
}
