using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorCsharp2
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal(tbxName.Text, int.Parse(tbxAge.Text), decimal.Parse(tbxPower.Text), decimal.Parse(tbxSpeed.Text));
            //Animal lion = new Animal("Lion", 23, 2000, 1234.56m);
            lblResult.Text = $"Animal Name: {myAnimal.Name}\nAnimal Age: {myAnimal.Age}\nAnimal Power: {myAnimal.Power}\nAnimal Speed: {myAnimal.Speed}";
            
            //
            //Clear TextBoxes
            //
            tbxName.Clear();
            tbxAge.Clear();
            tbxPower.Clear();
            tbxSpeed.Clear();

            myAnimal.IncreaseAge(4);
            myAnimal.IncreasePower(5);
            myAnimal.IncreaseSpeed(11.55m);

            lblIncAge.Text = $"{myAnimal.Age}\n{myAnimal.Power}\n{myAnimal.Speed}";
        }
    }
}
