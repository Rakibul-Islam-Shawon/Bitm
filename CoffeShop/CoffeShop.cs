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

        List<string> customerNames = new List<string>();
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();

        List<int> quantity = new List<int>();
        List<int> num= new List<int>();
        List<int> totalPrices = new List<int>();

       
        private int black = 120;
        private int cold = 100;
        private int hot = 90;
        private int regular = 80;


        public CoffeShop()
        {
            InitializeComponent();
        }


        public void SaveButton_Click(object sender, EventArgs e)
        {
           
            customerNames.Add(customerNameTextBox.Text);
            contactNo.Add(contactNoTextBox.Text);
            address.Add(addressTextBox.Text);
            quantity.Add(Convert.ToInt32(quantityTextBox.Text));
            order.Add(itemComboBox.Text);

            string message = " ";

            int index = 0;

            foreach (string customerName in customerNames)
            {

               if (order[index] == "Black")
                {
                    
                    totalPrices.Insert(index, (black * quantity[index]));
                }

                else if (order[index] == "Hot")
                {

                    totalPrices.Insert(index, (hot * quantity[index]));
                }
                else if (order[index] == "Cold")
                {
                    totalPrices.Insert(index, (cold * quantity[index]));

                }
                else if (order[index] == "Regular")
                {
                    totalPrices.Insert(index, (regular * quantity[index]));
                }

                message = message + "Name: " + customerName+ "\nContact No: " + contactNo[index] + "\nAddress: " + address[index] + "\nOrder: " + order[index] +
              "\nQuantity: " + quantity[index] + "\n\n\nTotal Price: " + totalPrices[index] + "\n\n";

                
                index++;

            }


            orderShowRichTextBox.Text = message;


          customerNameTextBox.Clear();
          contactNoTextBox.Clear();
          addressTextBox.Clear();
         quantityTextBox.Clear();
            
            

        }

    }
}
