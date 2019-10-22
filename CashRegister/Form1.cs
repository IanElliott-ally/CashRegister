using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace CashRegister
{
    public partial class textBox : Form
    {
        double steakCost = 46;
        double lobsterCost = 59;
        double pieCost = 23;
        double Tax = 0.13;
        int numOfSteaks = 0;
        int numOfLobsters = 0;
        int numOfPies = 0;
        int tendered = 0;
        double subTotalCost;
        double totalsteaksCost;
        double totallobstersCost;
        double totalpiesCost;
        double change,total, taxTotal;
        SoundPlayer typeSound = new SoundPlayer(Properties.Resources.Electric);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);


        public textBox()
        {
            InitializeComponent();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            numOfSteaks = Convert.ToInt32(steakBox.Text);
            numOfLobsters = Convert.ToInt32(lobsterBox.Text);
            numOfPies = Convert.ToInt32(pieBox.Text);


            totalsteaksCost = numOfSteaks * steakCost;
            totallobstersCost = numOfLobsters * lobsterCost;
            totalpiesCost = numOfPies * pieCost;
            subTotalCost = totalsteaksCost + totallobstersCost + totalpiesCost;
            taxTotal = subTotalCost * Tax;
            total = taxTotal + subTotalCost;

            subTotalLabel.Text = "Your Total Is: " + subTotalCost.ToString("C");
            taxLabel.Text = "Tax: " + taxTotal;
            totalLabel.Text = "Total Cost: " + total.ToString("C");



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void labelLobster_Click(object sender, EventArgs e)
        {

        }

        private void labelPie_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Load(object sender, EventArgs e)
        {

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();  
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font titlefont = new Font("Arial", 8);
            Font titlefont2 = new Font("Arial", 7);

            SoundPlayer typeSound = new SoundPlayer(Properties.Resources.Electric);
            typeSound.Play();
            // frame 1
            Thread.Sleep(1000);
            typeSound.Play();
            g.FillRectangle(whiteBrush, 490, 90, 230, 330);

            // frame 2
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Ian's Steakhouse", titlefont, blackBrush, 530, 110);

            // frame 3
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Steak: " + numOfSteaks + totalsteaksCost.ToString("C"), titlefont, blackBrush, 510, 140);

            // frame 4
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Lobster: " + numOfLobsters + totallobstersCost.ToString("C"), titlefont, blackBrush, 510, 170);

            // frame 5
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Pie: " + numOfPies +  totalpiesCost.ToString("C"), titlefont, blackBrush, 510, 200);

            // frame 6
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("SubTotal: " + subTotalCost.ToString("C"), titlefont, blackBrush, 510, 230);

            // frame 7
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Tax: " + taxTotal.ToString("C"), titlefont, blackBrush, 510, 260);

            // frame 8
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Total: " + total.ToString("C"), titlefont, blackBrush, 510, 290);

            // frame 9
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Tendered: " + tendered.ToString("C"), titlefont, blackBrush, 510, 320);

            // frame 10
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Change Due: " + change.ToString("C"), titlefont, blackBrush, 510, 350);

            // frame 11
            Thread.Sleep(1000);
            typeSound.Play();
            g.DrawString("Have A Wonderful Day And Come Back Soon!", titlefont2, blackBrush, 500, 390);

            typeSound.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToInt32(tenderedBox.Text);

            change = tendered - total;
            changeLabel.Text = "Your change due is: " + change.ToString("C") + "";
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);

            
            steakBox.Text = "";
            lobsterBox.Text = "";
            pieBox.Text = "";
            subTotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";
            changeLabel.Text = "";
            tenderedBox.Text = "";

            g.Clear(Color.Red);

        }

        private void changeLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
