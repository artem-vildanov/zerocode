using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zerocode
{
    public partial class Form1 : Form
    {
        struct car
        {
            public int minPrice;
            public int maxPrice;
            public string GB; //korobka
            public string rul; // left right
            public string privod;
            public double obyem;
            public string body;
            public string fuel;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_but_Click(object sender, EventArgs e)
        {

        }

        private void output_res_but_Click(object sender, EventArgs e)
        {
            
        }
    }
}
