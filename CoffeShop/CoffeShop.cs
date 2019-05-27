using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class CoffeShop : Form
    {
        const int size = 10;
        string[] customerName = new string[size];
        string[] contactNo = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];

        int[] quantity = new int[size];
        int[] num = new int[size];

        int[] totalPrice = new int[size];
        private int black = 120;
        private int cold = 100;
        private int hot = 90;
        private int regular = 80;

        string message = " ";


        public CoffeShop()
        {
            InitializeComponent();
        }


        public void SaveButton_Click(object sender, EventArgs e)
        {
            int index = 0;
           
            customerName[index] = customerNameTextBox.Text;
            contactNo[index] = contactNoTextBox.Text;
            address[index] = addressTextBox.Text;
            quantity[index] = Convert.ToInt16(quantityTextBox.Text);
            order[index] = itemComboBox.Text;
            

            if (order[index] == "Black")
            {
                totalPrice[index] = black * quantity[index];
            }

            else if (order[index] == "Hot") {

                totalPrice[index] = hot * quantity[index];
            }
            else if (order[index] == "Cold")
            {
                totalPrice[index] = cold * quantity[index];

            } 
            else if (order[index] == "Regular")
            {
                totalPrice[index] = regular * quantity[index];
            }
          

           message = message +"Name: " + customerName[index] + "\nContact No: " + contactNo[index] + "\nAddress: " + address[index] + "\nOrder: " + order[index] +
                "\nQuantity: " + quantity[index] + "\n\n\nTotal Price: " + totalPrice[index] + "\n\n";

            orderShowRichTextBox.Text = message;
            index++;

            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            quantityTextBox.Clear();
            

        }

    }
}
