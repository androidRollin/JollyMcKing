using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JollyMcKing
{

    public partial class Form1 : Form
    {
        const double MEAL1 = 35.00;
        const double MEAL2 = 35.00;
        const double MEAL3 = 50.00;
        const double MEAL4 = 60.00;
        const double TAPSILOG = 45.00;
        const double TOCILOG = 28.00;
        const double HOTSILOG = 20.00;
        const double HAMSILOG = 23.00;
        const double SODA = 15.00;
        const double ICEDTEA = 17.00;
        const double JUICE = 25.00;
        const double UPSIZE = 10.00;

        String username01 = "user01";
        String userpass01 = "userpass01";

        int trial = 3;

        bool isRbUpSizeChecked = false;

        double total = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            //tbUserName.Text = username01;
            //tbUserPass.Text = userpass01;

            if (!(String.Equals(username01, tbUserName.Text.ToString())) && !(String.Equals(userpass01, tbUserPass.Text.ToString())))
            {
                --trial;
                MessageBox.Show($"Invalid Credentials, remaining trial is {trial}", "Error Message");

            }
            else
            {
                groupBox1.Enabled = false;
                MessageBox.Show("Log in Successfuly", "Log-In");
                groupBox2.Enabled = true;
            }
            if (trial == 0)
            {
                this.Close();
            }
        }

        private void cbMeal1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void AddToTotal(double orderCost)
        {
            total += orderCost;
            tbTotalAmount.Text = total.ToString();
        }

        private void cbMeal2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbMeal3_CheckedChanged(object sender, EventArgs e)
        {


        }

        //RolineGwaps

        private void cbMeal4_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbTapsilog_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbHotsilog_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbTocilog_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbHamsilog_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void cbSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoda.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                if (!(cbSoda.Checked) && !(cbIcedTea.Checked) && !(cbJuice.Checked))
                {
                    panel1.Enabled = false;
                    rbUpSize.Checked = false;
                }

            }
        }

        private string GetBeveragePrice(double beverage)
        {
            if (rbUpSize.Checked)
            {
               // MessageBox.Show("radio button upsize is active", "Order");
                beverage += UPSIZE;
            }
            return beverage.ToString();
        }

        private void cbIcedTea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIcedTea.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                if (!(cbSoda.Checked) && !(cbIcedTea.Checked) && !(cbJuice.Checked))
                {
                    panel1.Enabled = false;
                    rbUpSize.Checked = false;
                }
            }
        }

        private void cbJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJuice.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                if (!(cbSoda.Checked) && !(cbIcedTea.Checked) && !(cbJuice.Checked))
                {
                    panel1.Enabled = false;
                    rbUpSize.Checked = false;
                }
            }
        }

    



        private void AddToListView(string name, string v)
        {
            string[] row = { name, v };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox3.Enabled == false)
            {
                groupBox3.Enabled = true;
            }

            if (cbValueMeal.Checked)
            {
                cbMeal1.Enabled = true;
                cbMeal3.Enabled = true;
                cbMeal2.Enabled = true;
                cbMeal4.Enabled = true;
            }
            if (!cbValueMeal.Checked)
            {
                cbMeal1.Enabled = false;
                cbMeal3.Enabled = false;
                cbMeal2.Enabled = false;
                cbMeal4.Enabled = false;
                cbMeal1.Checked = false;
                cbMeal3.Checked = false;
                cbMeal2.Checked = false;
                cbMeal4.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox3.Enabled == false)
            {
                groupBox3.Enabled = true;
            }
            if (cbRiceMeal.Checked)
            {
                cbTapsilog.Enabled = true;
                cbTocilog.Enabled = true;
                cbHotsilog.Enabled = true;
                cbHamsilog.Enabled = true;
            }
            if (!cbRiceMeal.Checked)
            {
                cbTapsilog.Enabled = false;
                cbTocilog.Enabled = false;
                cbHotsilog.Enabled = false;
                cbHamsilog.Enabled = false;
                cbTapsilog.Checked = false;
                cbTocilog.Checked = false;
                cbHotsilog.Checked = false;
                cbHamsilog.Checked = false;
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            if (groupBox3.Enabled == false)
            {
                groupBox3.Enabled = true;
            }
            if (cbBeverages.Checked)
            {
                cbSoda.Enabled = true;
                cbIcedTea.Enabled = true;
                cbJuice.Enabled = true;
            }
            if (!cbBeverages.Checked)
            {
                cbSoda.Enabled = false;
                cbIcedTea.Enabled = false;
                cbJuice.Enabled = false;
                cbSoda.Checked = false;
                cbIcedTea.Checked = false;
                cbJuice.Checked = false;
            }

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbUpSize_CheckedChanged(object sender, EventArgs e)
        {
            isRbUpSizeChecked = rbUpSize.Checked;
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            tbAmountGiven.Text = string.Empty;
            tbChange.Text = string.Empty;
            if((!rbDriveIn.Checked) && (!rbTakeOut.Checked))
            {
                MessageBox.Show("Please select type of Order, before ordering, thanks!", "Order");
                return;
            }

            /**
            if((!cbValueMeal.Checked) && (!cbRiceMeal.Checked) && (!cbBeverages.Checked))
            {
                MessageBox.Show("Please select an order ", "Order");
                return;
            }**/
            displayOrderInListView();
            if (total == 0)
            {
                MessageBox.Show("Please Order Something", "Order");
                return;
            }



            MessageBox.Show("Order processed, please proceed to Payment", "Order");
            groupBox4.Enabled = true;


        }

        private void displayOrderInListView()
        {
            listView1.Items.Clear();
            total = 0;
            if (cbMeal1.Checked == true)
            {
                AddToListView(cbMeal1.Text, MEAL1.ToString());
                AddToTotal(MEAL1);
            }
            if (cbMeal2.Checked)
            {
                AddToListView(cbMeal2.Text, MEAL2.ToString());
                AddToTotal(MEAL2);
            }
            if (cbMeal3.Checked)
            {
                AddToListView(cbMeal3.Text, MEAL3.ToString());
                AddToTotal(MEAL3);
            }
            if (cbMeal4.Checked)
            {
                AddToListView(cbMeal4.Text, MEAL4.ToString());
                AddToTotal(MEAL4);
            }
            if (cbTapsilog.Checked)
            {
                AddToListView(cbTapsilog.Text, TAPSILOG.ToString());
                AddToTotal(TAPSILOG);
            }
            if (cbHotsilog.Checked)
            {
                AddToListView(cbHotsilog.Text, HOTSILOG.ToString());
                AddToTotal(HOTSILOG);
            }
            if (cbTocilog.Checked)
            {
                AddToListView(cbTocilog.Text, TOCILOG.ToString());
                AddToTotal(TOCILOG);
            }
            if (cbHamsilog.Checked)
            {
                AddToListView(cbHamsilog.Text, HAMSILOG.ToString());
                AddToTotal(HAMSILOG);
            }
            if (cbSoda.Checked)
            {
                string beveragePrice = GetBeveragePrice(SODA);
                AddToListView(cbSoda.Text, beveragePrice);
                AddToTotal(Convert.ToDouble(beveragePrice));
            }
            if (cbIcedTea.Checked)
            {
                string beveragePrice = GetBeveragePrice(ICEDTEA);
                AddToListView(cbIcedTea.Text, beveragePrice);
                AddToTotal(Convert.ToDouble(beveragePrice));
            }
            if (cbJuice.Checked)
            {
                string beveragePrice = GetBeveragePrice(JUICE);
                AddToListView(cbJuice.Text, beveragePrice);
                AddToTotal(Convert.ToDouble(beveragePrice));
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            tbChange.Text = string.Empty;
            if (String.IsNullOrEmpty(tbAmountGiven.Text))
            {
                MessageBox.Show("You didn't enter any payment, Please Try Again", "Payment");
                return;
            }
            int parsedValue;
            if (!int.TryParse(tbAmountGiven.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field", "Payment");
                return;
            }
            double custPayment = 0.00;
            custPayment = Convert.ToDouble(tbAmountGiven.Text);
            if (custPayment <= 0 || custPayment < total)
            {
                MessageBox.Show("Insufficient Amount, Please enter a valid amount", "Payment");
                return;
            }
            if (custPayment >= total)
            {
                double change = custPayment - total;
                tbChange.Text = change.ToString();
            }

        }

        private void rbUpSize_Click(object sender, EventArgs e)
        {
            if (rbUpSize.Checked && !isRbUpSizeChecked)
                rbUpSize.Checked = false;
            else
            {
                rbUpSize.Checked = true;
                isRbUpSizeChecked = false;
            }
        }
    }
}
