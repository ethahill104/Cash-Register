using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{


    public partial class Form1 : Form
    {
        int tendered;
        double totalCostOfOrder; // varible for the total before the tax
        double totalCost; //varible for the Total
        const double tax = 0.13; //varible for tax
        double taxTotal; // varible for the total of the tax
        double change;
        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
             try {
            const double itemPrice1 = 999; //price of item 1
            const double itemPrice2 = 220; //price of item 2
            const double itemPrice3 = 59;//price of item 3
            const double itemPrice4 = 19;//price of item 4


            double numberOf1 = Convert.ToInt16(textBox1.Text);//grabs the information that the user has entered
            double numberOf2 = Convert.ToInt16(textBox3.Text);//grabs the information that the user has entered
            double numberOf3 = Convert.ToInt16(textBox2.Text); //grabs the information that the user has entered
            double numberOf4 = Convert.ToInt16(textBox4.Text); //grabs the information that the user has entered



            totalCostOfOrder = itemPrice1 * numberOf1 + itemPrice2 * numberOf2 + itemPrice3 * numberOf3 + itemPrice4 * numberOf4; //total cost is the cost of the item multiplyed by however many of that item they bought 
            totalCost = totalCostOfOrder + tax; 
            taxTotal = totalCostOfOrder * tax;

            subTotal.Text = "Sub Total $" + totalCostOfOrder; 
            Tax.Text = "Tax $" + taxTotal;
            TotalCost.Text = "Total $" + totalCost;
            label8.Text = "";

            }
            catch {
                label8.Text = "Please enter an integer";
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {

         
           
            try
            {
                double tendered = Convert.ToDouble(textBox5.Text);
                change = tendered - totalCost;

                changeBox.Text = "Change $" + change;
                label8.Text = ""; //if the user enters the an appropirate amount then nothing will be displayed
            }
            catch
            { label8.Text = "Please enter an integer"; //if user enters a inappropriate amount then this displays an error message 
            }
           

       





    }

        private void Print_Click(object sender, EventArgs e)
        {
           
            

            const double itemPrice1 = 999; //price of item 1
            const double itemPrice2 = 220; //price of item 2
            const double itemPrice3 = 59;//price of item 3
            const double itemPrice4 = 19;//price of item 4

            double numberOf1 = Convert.ToInt16(textBox1.Text); //grabs the information that the user has entered
            double numberOf2 = Convert.ToInt16(textBox3.Text); //grabs the information that the user has entered
            double numberOf3 = Convert.ToInt16(textBox2.Text); //grabs the information that the user has entered
            double numberOf4 = Convert.ToInt16(textBox4.Text); //grabs the information that the user has entered

          

            double totalCostOfOrder;
            totalCostOfOrder = itemPrice1 * numberOf1 + itemPrice2 * numberOf2 + itemPrice3 * numberOf3 + itemPrice4 * numberOf4; // calculates the subtotal
            totalCost = totalCostOfOrder + tax; // calculates the total 
            taxTotal = totalCostOfOrder * tax; // calculates the total amount of tax for the order
            double tendered = Convert.ToDouble(textBox5.Text); //grabs the information that the user has entered

            label5.Text = "Receipt";

            label6.Text += "Iphone X  x" + numberOf1 + " @ $" + itemPrice1 + "\n"; //displays number of Iphones bought and how much the total is
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "AirPods  x" + numberOf2 + " @ $" + itemPrice2 + "\n"; //displays number of Airpods bought and how much the total is
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Charging Adapter  x" + numberOf3 + " @ $" + itemPrice3 + "\n"; //displays number of Charging adapters bought and how much the total is
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Charging Cable  x" + numberOf4 + " @ $" + itemPrice4 + "\n"; //displays number of Chagrging cabels bought and how much the total is
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Sub Total:  " + totalCostOfOrder + "\n"; //displays the total before the tax is added
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Tax:  " + taxTotal + "\n"; //displays the total tax of the order
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Total:  " + totalCost + "\n"; //displays the total cost of the order
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Tendered:  " + tendered + "\n"; //displays the amount tendered that the user entered
            Refresh();
            Thread.Sleep(1000);
            label6.Text += "Change  " + change + "\n"; //displays the change that the user will get back
            Refresh();
            Thread.Sleep(1000);
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
