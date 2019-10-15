using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class tenderedBox : Form
    {
        double steakCost = 46;
        double lobsterCost = 59;
        double pieCost = 23;
        double Tax = 0.13;
        int numOfSteaks = 0;
        int numOfLobsters = 0;
        int numOfPies = 0;
        double totalCost;
        double totalsteaksCost;
        double totallobstersCost;
        double totalpiesCost;
        double Tender;
        double change;



        public tenderedBox()
        {
            InitializeComponent();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            numOfSteaks = Convert.ToInt32(steaksInput.Text);
            totalsteaksCost = numOfSteaks * steakCost;
            numOfLobsters = Convert.ToInt32(lobstersInput.Text);
            totallobstersCost = numOfLobsters * lobsterCost;
            numOfPies = Convert.ToInt32(piesInput.Text);
            totalpiesCost = numOfPies * pieCost;

            totalCost = steakCost + totalsteaksCost + lobsterCost + totallobstersCost + pieCost + totalpiesCost;
            totalLabel.Text = "Your Total Is:" + totalCost.ToString("C");

        }

        private void labelLobster_Click(object sender, EventArgs e)
        {

        }

        private void labelPie_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
