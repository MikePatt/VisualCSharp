using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxerChampion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            string boxName = tbxName.Text;
            int numWon = int.Parse(tbxWon.Text);
            int numLost = int.Parse(tbxLost.Text);

            lblWinResult.Text = (numWon > numLost ? $"{boxName} is a Champion!" : $"{boxName} is a Loser!");

            if (numWon >= 100)
            {
                lblEval.Text = $"{boxName} is a Legend!";
            }
        }
    }
}
