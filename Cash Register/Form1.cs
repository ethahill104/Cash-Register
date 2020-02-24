using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{


    public partial class Form1 : Form
    {

        double totalCostOfOrder;
        double totalCost;
        const double tax = 0.13;
        double taxTotal;
        double change;
        double tendered;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
           

            const double itemPrice1 = 999; //price of item 1
            const double itemPrice2 = 220; //price of item 2
            const double itemPrice3 = 49;//price of item 3
            const double itemPrice4 = 19;//price of item 4

            double numberOf1 = Convert.ToInt16(textBox1.Text);
            double numberOf2 = Convert.ToInt16(textBox3.Text);
            double numberOf3 = Convert.ToInt16(textBox2.Text);
            double numberOf4 = Convert.ToInt16(textBox4.Text);
          


            totalCostOfOrder = itemPrice1 * numberOf1 + itemPrice2 * numberOf2 + itemPrice3 * numberOf3 + itemPrice4 * numberOf4;
            totalCost = totalCostOfOrder + tax;
            taxTotal = totalCostOfOrder * tax;

            subTotal.Text = "Sub Total $" + totalCostOfOrder;
            Tax.Text = "Tax $" + taxTotal;
            TotalCost.Text = "Total $" + totalCost;



        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            double tendered = Convert.ToDouble(textBox5.Text);
            change = tendered - totalCost;

            changeBox.Text = "Change $" + change; 

        }

        private void Print_Click(object sender, EventArgs e)
        {
           
            

            const double itemPrice1 = 999; //price of item 1
            const double itemPrice2 = 220; //price of item 2
            const double itemPrice3 = 49;//price of item 3
            const double itemPrice4 = 19;//price of item 4

            double numberOf1 = Convert.ToInt16(textBox1.Text);
            double numberOf2 = Convert.ToInt16(textBox3.Text);
            double numberOf3 = Convert.ToInt16(textBox2.Text);
            double numberOf4 = Convert.ToInt16(textBox4.Text);
           


            double totalCostOfOrder;
            totalCostOfOrder = itemPrice1 * numberOf1 + itemPrice2 * numberOf2 + itemPrice3 * numberOf3 + itemPrice4 * numberOf4;
            totalCost = totalCostOfOrder + tax;
            taxTotal = totalCostOfOrder * tax;

            label5.Text = "Receipt";

            label6.Text += "Sub Total:  " + totalCostOfOrder + "\n";
            label6.Text += "Tax:  " + taxTotal + "\n";
            label6.Text += "Total:  " + totalCost + "\n";
            label6.Text += "Tendered:  " + tendered + "\n";
            label6.Text += "Change  " + change + "\n";

        }
    }
}
