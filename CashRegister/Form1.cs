using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double travis, burger, fanta, subtotal, tax, total, tendered, change;
        double travisCost = 12.50;
        double burgerCost = 15;
        double fantaCost = 4.50;
        double taxRate = 0.13;

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                //print everything
                printLabel.Text = $"\n\n         Fortnite Item Shop";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal} \n Tax ${tax}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal} \n Tax ${tax} \n Total ${total}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal} \n Tax ${tax} \n Total ${total}\n\n Tendered ${tendered}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal} \n Tax ${tax} \n Total ${total}\n\n Tendered ${tendered} \n Change ${change}";

                Refresh();
                Thread.Sleep(300);

                printLabel.Text = $"\n\n         Fortnite Item Shop\n\n Order Number: 1234\n February 22, 2022\n\n Travis Scott x{travis} @ ${travisCost}\n Mr. Beast Burger x{burger} @ ${burgerCost}\n Fanta x{fanta} @ ${fantaCost}\n\n Subtotal ${subtotal} \n Tax ${tax} \n Total ${total}\n\n Tendered ${tendered} \n Change ${change} \n\n If you go to a river, the ducks are free!";

            }
            catch
            {

            }
            }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {

                //tendered input
                tendered = Convert.ToDouble(tenderedInput.Text);

                //calculate
                change = tendered - total;

                //output
                changeOutput.Text = change.ToString("C");


               
            }
            catch
            {
                errorLabel.Text = "Please enter a numerical value!";
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
                }
            catch
            {
                errorLabel.Text = "Please type a numerical value.";
            }
            }
            
            }
            

        }
    

