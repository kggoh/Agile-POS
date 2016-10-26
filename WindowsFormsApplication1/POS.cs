using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
     
    public partial class POS : Form
    {
        Order o = new Order();
        public POS()
        {
            InitializeComponent();

            listBox1.Items.Add("Red shirt");
            listBox1.Items.Add("Blue shirt");
            listBox1.Items.Add("Yellow shirt");
            listBox1.Items.Add("Green shirt");
            listBox1.Items.Add("Purple shirt");



            comboBox1.Items.Add("Multi-Item");
            comboBox1.Items.Add("Progressive Discount");
      


            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString() + " x " + comboBox2.SelectedItem.ToString());
            o.Add(Products.GetProduct(listBox1.SelectedItem.ToString()), Convert.ToInt16(comboBox2.SelectedItem.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Promotion promo;
            DiscountCalculator dc;

            if(comboBox1.SelectedItem.Equals("Multi-Item"))
            {
                promo = new Promotion("multi", 0.30, Convert.ToInt16(comboBox2.SelectedItem.ToString()));
                dc = new DiscountCalculator(promo);
        

                
               //.Add(Products.GetProduct(listBox1.SelectedItem.ToString()), Convert.ToInt16(comboBox2.SelectedItem.ToString()));

                //exercise
                Order newOrder = dc.CalculateDiscount(o);
                label5.Text = "$" + newOrder.DiscountedPrice;

            }
            else
            {
                promo = new Promotion("progressive", 0.10, Convert.ToInt16(comboBox2.SelectedItem.ToString()));
                dc = new DiscountCalculator(promo);
             // Order o = new Order();
              //o.Add(Products.GetProduct(listBox1.SelectedItem.ToString()), Convert.ToInt16(comboBox2.SelectedItem.ToString()));

                //exercise
                Order newOrder = dc.CalculateDiscount(o);
                label5.Text = "$" + newOrder.DiscountedPrice;
            }

        }

    }
}
