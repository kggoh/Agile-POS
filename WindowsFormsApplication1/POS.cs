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
        public POS()
        {
            InitializeComponent();

            listBox1.Items.Add("Red shirt");
            listBox1.Items.Add("Blue shirt");
            listBox1.Items.Add("Yellow shirt");
            listBox1.Items.Add("Green shirt");
            listBox1.Items.Add("Purple shirt");



            comboBox1.Items.Add("10% company make little money");
            comboBox1.Items.Add("20% company loss");
            comboBox1.Items.Add("30% company bankrupt");


            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem.ToString() + " x " + comboBox2.SelectedItem.ToString());
        }

    }
}
