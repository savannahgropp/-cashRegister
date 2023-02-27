using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double travis, burger, fanta, subtotal, tax, total, tendered, change, travisCost, burgerCost, taxRate, fantaCost;
        

        private void resetButton_Click(object sender, EventArgs e)
        {
            tenderedInput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            travisInput.Text = "";
            burgerInput.Text = "";
            fantaInput.Text = "";
            changeOutput.Text = "";
            printLabel.Text = "";
        }
        

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";
                //sounds
                SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printSound2);
                printerSound.Play();

                //disable buttons
                printButton.Enabled = false;
                calculateChangeButton.Enabled = false;
                //print everything

                Refresh();
                Thread.Sleep(200);

                printLabel.Text = $"\n\n         Fortnite Item Shop";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")} \n Tax                     {tax.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")} \n Tax                     {tax.ToString("C")} \n Total                   {total.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")} \n Tax                     {tax.ToString("C")} \n Total                   {total.ToString("C")}\n\n Tendered                {tendered.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost .ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")} \n Tax                     {tax.ToString("C")} \n Total                   {total.ToString("C")}\n\n Tendered                {tendered.ToString("C")} \n Change                  {change.ToString("C")}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott            x{travis} @ {travisCost.ToString("C")}\n Mr. Beast Burger        x{burger} @ {burgerCost.ToString("C")}\n Fanta                   x{fanta} @ {fantaCost.ToString("C")}\n\n Subtotal                {subtotal.ToString("C")} \n Tax                     {tax.ToString("C")} \n Total                   {total.ToString("C")}\n\n Tendered                {tendered.ToString("C")} \n Change                  {change.ToString("C")} \n\n If you go to a river, the ducks are free!";

            }
            catch
            {
                
            }
            }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Text = "";
                //tendered input
                tendered = Convert.ToDouble(tenderedInput.Text);

                //calculate
                change = tendered - total;

                //output
                changeOutput.Text = change.ToString("C");

                //make things visible
                changeLabel.Visible = true;
                changeOutput.Visible = true;
                printButton.Visible = true;

                printButton.Enabled = true;
            }
            catch
            {
                errorLabel.Text = "Please enter a numerical value!";
                printButton.Enabled = false;
            }
            }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
            {
                try
                {
                travisCost = 12.50;
                burgerCost = 15;
                fantaCost = 4.50;
                taxRate = 0.13;

                errorLabel.Text = "";
                    //get inputs
                    travis = Convert.ToDouble(travisInput.Text);
                    burger = Convert.ToDouble(burgerInput.Text);
                    fanta = Convert.ToDouble(fantaInput.Text);

                //calculate
                subtotal = (travis * travisCost) + (burger * burgerCost) + (fanta * fantaCost);
                    tax = subtotal * taxRate;
                    total = subtotal + tax;

                    //output
                    subtotalOutput.Text = subtotal.ToString("C");
                    taxOutput.Text = tax.ToString("C");
                    totalOutput.Text = total.ToString("C");

                //make things visible
                subtotalLabel.Visible = true;
                subtotalOutput.Visible = true;
                taxLabel.Visible = true;
                taxOutput.Visible = true;
                totalLabel.Visible = true;
                totalOutput.Visible = true;
                tenderedLabel.Visible = true;
                tenderedInput.Visible = true;
                label5.Visible= true;
                calculateChangeButton.Visible = true;

                calculateChangeButton.Enabled = true;
            }
            catch
            {
                errorLabel.Text = "Please type a numerical value.";
                calculateChangeButton.Enabled = false;
            }
            }
            
            }
            

        }
    

