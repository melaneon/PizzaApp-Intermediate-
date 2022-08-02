using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem10
{
    public partial class Form1 : Form
    {
        float total;
        float size;
        float topping;
        float extras;

        public Form1()
        {
            InitializeComponent();

            total = 0f;
            size = 0f;
            topping = 0f;
            extras = 0f;
        }

        private void CalculatePizzaCost()
        {
            total = size + topping + extras;
            txtTotal.Text = String.Format("{0:C}", total);
        }

        //Check for changes in Size.
        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            CheckForSmall();
            CheckForMedium();
            CheckForLarge();
            CheckForKind();
            CheckForToppings();
            CalculatePizzaCost();
        }
        private void CheckForSmall()
        {
            if (rdoSmallSize.Checked == true)
            {
                int index = order.FindString("Size: Small");
                if (index == -1)
                {
                    size = 10.5f;
                    order.Items.Add("Size: Small");
                }
            }
            if (rdoSmallSize.Checked == false)
            {
                int index = order.FindString("Size: Small");
                if (index >= 0)
                {
                    order.Items.Remove("Size: Small");
                    order.Items.Remove("Toppings: none");
                }
            }

        }
        private void CheckForMedium()
        {
            if (rdoMediumSize.Checked == true)
            {
                int index = order.FindString("Size: Medium");
                if (index == -1)
                {
                    size = 12.5f;
                    order.Items.Add("Size: Medium");
                }
            }
            if (rdoMediumSize.Checked == false)
            {
                int index = order.FindString("Size: Medium");
                if (index >= 0)
                {
                    order.Items.Remove("Size: Medium");
                    order.Items.Remove("Toppings: none");
                }
            }
        }
        private void CheckForLarge()
        {
            if (rdoLargeSize.Checked == true)
            {
                int index = order.FindString("Size: Large");
                if (index == -1)
                {
                    size = 17.5f;
                    order.Items.Add("Size: Large");
                }
            }
            if (rdoLargeSize.Checked == false)
            {
                int index = order.FindString("Size: Large");
                if (index >= 0)
                {
                    order.Items.Remove("Size: Large");
                    order.Items.Remove("Toppings: none");
                }
            }
        }





        //Check for changes in Toppings.
        private void CheckForToppings()
        {
            int index = order.FindString("Toppings: Pepperonni");
            int index2 = order.FindString("Toppings: Black Olives");
            int index3 = order.FindString("Toppings: Mushrooms");
            if (index == -1 && index2 == -1 && index3 == -1)
            {
                order.Items.Add("Toppings: none");
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked == true ||
                rdoMediumSize.Checked == true ||
                rdoLargeSize.Checked == true)
            {

                if (checkBox3.Checked == true)
                {
                    topping = topping + 5;
                    order.Items.Remove("Toppings: none");
                    order.Items.Add("Toppings: Pepperonni");
                    CalculatePizzaCost();
                }
                if (checkBox3.Checked == false)
                {
                    topping = topping -5; 
                    order.Items.Remove("Toppings: Pepperonni");
                    CalculatePizzaCost();
                }
               
                CheckForToppings();
                
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked == true ||
                rdoMediumSize.Checked == true ||
                rdoLargeSize.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    topping = topping + 3;
                    order.Items.Remove("Toppings: none");
                    order.Items.Add("Toppings: Black Olives");
                    CalculatePizzaCost();
                }
                if (checkBox2.Checked == false)
                {
                    topping = topping -3;
                    order.Items.Remove("Toppings: Black Olives");
                    CalculatePizzaCost();
                }
                
                CheckForToppings();

            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked == true ||
                rdoMediumSize.Checked == true ||
                rdoLargeSize.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    topping = topping + 2;
                    order.Items.Remove("Toppings: none");
                    order.Items.Add("Toppings: Mushrooms");
                    CalculatePizzaCost();
                }
                if (checkBox1.Checked == false)
                {
                    topping = topping -2;
                    order.Items.Remove("Toppings: Mushrooms");
                    CalculatePizzaCost();
                }
                CheckForToppings();
            }
        }





        //Check for changes in PizzaKind.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckForKind();
        }

        private void CheckForKind()
        {
            CheckFor1();
            CheckFor2();
            CheckFor3();
            CheckFor4();
            CheckFor5();
            CheckFor6();
            CheckFor7();
            CheckFor8();
            CheckFor9();
            CheckFor10();
        }

        private void CheckFor1()
        {
            int index = order.FindString("Cheese");

            if (listBox1.SelectedItems.Contains("Cheese"))
            {
                if (index == -1)
                {
                    order.Items.Add("Cheese");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 8f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 10f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 15f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Cheese");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor2()
        {
            int index = order.FindString("Neapolitan");

            if (listBox1.SelectedItems.Contains("Neapolitan"))
            {
                if (index == -1)
                {
                    order.Items.Add("Neapolitan");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 8f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 10f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 15f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Neapolitan");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor3()
        {

            int index = order.FindString("Margherita");

            if (listBox1.SelectedItems.Contains("Margherita"))
            {
                if (index == -1)
                {
                    order.Items.Add("Margherita");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 8f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 10f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 15f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Margherita");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor4()
        {

            int index = order.FindString("Calzone");

            if (listBox1.SelectedItems.Contains("Calzone"))
            {
                if (index == -1)
                {
                    order.Items.Add("Calzone");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 10.5f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 12.5f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 17.5f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Calzone");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor5()
        {
            int index = order.FindString("Stromboli");

            if (listBox1.SelectedItems.Contains("Stromboli"))
            {
                if (index == -1)
                {
                    order.Items.Add("Stromboli");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 10.5f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 12.5f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 17.5f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Stromboli");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor9()
        {
            int index = order.FindString("Deep Dish");

            if (listBox1.SelectedItems.Contains("Deep Dish"))
            {
                if (index == -1)
                {
                    order.Items.Add("Deep Dish");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 10.5f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 12.5f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 17.5f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Deep Dish");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor6()
        {
            int index = order.FindString("Marinara");

            if (listBox1.SelectedItems.Contains("Marinara"))
            {
                if (index == -1)
                {
                    order.Items.Add("Marinara");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 10.5f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 12.5f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 17.5f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Marinara");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor7()
        {
            int index = order.FindString("Hawaiian");

            if (listBox1.SelectedItems.Contains("Hawaiian"))
            {
                if (index == -1)
                {
                    order.Items.Add("Hawaiian");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 10.5f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 12.5f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 17.5f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Hawaiian");
                }
            }
            CalculatePizzaCost();
        }
        private void CheckFor8()
        {
            int index = order.FindString("Lahma Bi Ajeen");

            if (listBox1.SelectedItems.Contains("Lahma Bi Ajeen"))
            {
                if (index == -1)
                {
                    order.Items.Add("Lahma Bi Ajeen");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 11f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 13f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 18f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("Lahma Bi Ajeen");
                }
            }
            CalculatePizzaCost();
        }

        private void CheckFor10()
        {
            int index = order.FindString("The M&L Special");

            if (listBox1.SelectedItems.Contains("The M&L Special"))
            {
                if (index == -1)
                {
                    order.Items.Add("The M&L Special");
                }
                if (rdoSmallSize.Checked == true)
                {
                    size = 12f;
                }
                if (rdoMediumSize.Checked == true)
                {
                    size = 14f;
                }
                if (rdoLargeSize.Checked == true)
                {
                    size = 19f;
                }
            }
            else
            {
                if (index >= 0)
                {
                    order.Items.Remove("The M&L Special");
                }
            }
            CalculatePizzaCost();
        }

        private void cboDietary_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Instead of using listBox1.Items.Sort() I set order in Properties.

            /*Also, I used .Add instead of .Remove beacuse 
            it could do not return more items after choosing more strict diet
            
             For example, if you'd choose Vegan diet first and decided to choose regular after 
            you wouldn't see previous options*/

            UnselectPizzaKind();
            if (cboDietary.SelectedItem == "N/A")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Hawaiian");
                listBox1.Items.Add("Calzone");
                listBox1.Items.Add("Lahma Bi Ajeen");
                listBox1.Items.Add("The M&L Special");
                listBox1.Items.Add("Cheese");
                listBox1.Items.Add("Neapolitan");
                listBox1.Items.Add("Margherita");
                listBox1.Items.Add("Deep Dish");
                listBox1.Items.Add("Marinara");
                listBox1.Items.Add("Stromboli");

            }
            else if (cboDietary.SelectedItem == "100 mile" ||
                cboDietary.SelectedItem == "Kosher")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Calzone");
                listBox1.Items.Add("Lahma Bi Ajeen");
                listBox1.Items.Add("The M&L Special");
                listBox1.Items.Add("Cheese");
                listBox1.Items.Add("Neapolitan");
                listBox1.Items.Add("Margherita");
                listBox1.Items.Add("Deep Dish");
                listBox1.Items.Add("Marinara");
                listBox1.Items.Add("Stromboli");
            }
            else if (cboDietary.SelectedItem == "Gluten free" ||
                cboDietary.SelectedItem == "Lactose" ||
                cboDietary.SelectedItem == "Paleo")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Hawaiian");
                listBox1.Items.Add("Stromboli");
                listBox1.Items.Add("Calzone");
                listBox1.Items.Add("Lahma Bi Ajeen");
                listBox1.Items.Add("The M&L Special");
                listBox1.Items.Add("Marinara");
            }

            else if (cboDietary.SelectedItem == "Non-GMO")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Hawaiian");
                listBox1.Items.Add("Calzone");
                listBox1.Items.Add("Lahma Bi Ajeen");
                listBox1.Items.Add("The M&L Special");
                listBox1.Items.Add("Cheese");
                listBox1.Items.Add("Neapolitan");
                listBox1.Items.Add("Margherita");
                listBox1.Items.Add("Deep Dish");
                listBox1.Items.Add("Marinara");
            }
            else if (cboDietary.SelectedItem == "Vegan")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Marinara");

            }
            else if (cboDietary.SelectedItem == "Vegetarian")
            {
                listBox1.Items.Clear();

                listBox1.Items.Add("Cheese");
                listBox1.Items.Add("Neapolitan");
                listBox1.Items.Add("Margherita");
                listBox1.Items.Add("Deep Dish");
                listBox1.Items.Add("Marinara");
            }

        }
        private void UnselectPizzaKind()
        {
            order.Items.Remove("Hawaiian");
            order.Items.Remove("Calzone");
            order.Items.Remove("Lahma Bi Ajeen");
            order.Items.Remove("The M&L Special");
            order.Items.Remove("Cheese");
            order.Items.Remove("Neapolitan");
            order.Items.Remove("Margherita");
            order.Items.Remove("Deep Dish");
            order.Items.Remove("Marinara");
            order.Items.Remove("The M&L Special");
            order.Items.Remove("Stromboli");
        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rdoSmallSize.Checked = false;
            rdoMediumSize.Checked = false;
            rdoLargeSize.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            cboDietary.Text = "";
            order.Items.Clear();
            listBox1.ClearSelected();
            txtTotal.Text = "";
            total = 0f;
            listBox1.Items.Clear();

            listBox1.Items.Add("Hawaiian");
            listBox1.Items.Add("Calzone");
            listBox1.Items.Add("Lahma Bi Ajeen");
            listBox1.Items.Add("The M&L Special");
            listBox1.Items.Add("Cheese");
            listBox1.Items.Add("Neapolitan");
            listBox1.Items.Add("Margherita");
            listBox1.Items.Add("Deep Dish");
            listBox1.Items.Add("Marinara");
            listBox1.Items.Add("Stromboli");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brought to you by the brothers Mario and Luigi!");
        }

        private void chkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCola.Checked == true)
            {
                extras = 2.5f;
                order.Items.Add("Drinks: Cola");
                order.Items.Remove("Drinks: none");
            }
            if (chkCola.Checked == false)
            {
                extras = extras - 2.5f;
                order.Items.Remove("Drinks: Cola");
            }
            CalculatePizzaCost();
            CheckforDrinks();
        }

        private void chkJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJuice.Checked == true)
            {
                extras = extras + 3f;
                order.Items.Add("Drinks: Juice");
                order.Items.Remove("Drinks: none");
            }
            if (chkJuice.Checked == false)
            {
                extras = extras - 3f;
                order.Items.Remove("Drinks: Juice");
            }
            CalculatePizzaCost();
            CheckforDrinks();
        }

        private void chkApplePie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApplePie.Checked == true)
            {
                extras = extras + 3f;
                order.Items.Add("Dessert: Apple Pie");
                order.Items.Remove("Desserts: none");
            }
            if (chkApplePie.Checked == false)
            {
                extras = extras - 3f;
                order.Items.Remove("Dessert: Apple Pie");
            }
            CalculatePizzaCost();
            CheckforDesserts();
        }

        private void chkChocCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocCake.Checked == true)
            {
                extras = extras + 4f;
                order.Items.Add("Dessert: Chocolate Cake");
                order.Items.Remove("Desserts: none");
            }
            if (chkChocCake.Checked == false)
            {
                extras = extras -4f;
                order.Items.Remove("Dessert: Chocolate Cake");
            }
            CalculatePizzaCost();
            CheckforDesserts();
        }
        private void CheckforDrinks()
        {
            int index = order.FindString("Drinks: Cola");
            int index2 = order.FindString("Drinks: Juice");
            
            if (index == -1 && index2 == -1)
            {
                order.Items.Add("Drinks: none");
            }
        }
        private void CheckforDesserts()
        {

            int index3 = order.FindString("Dessert: Apple Pie");
            int index4 = order.FindString("Dessert: Chocolate Cake");
            if (index3 == -1 && index4 == -1)
            {
                order.Items.Add("Desserts: none");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
