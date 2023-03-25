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
            private int minPrice;
            private int maxPrice;
            private string GB; //korobka
            private string rul; // left right
            private string privod;
            private double obyem;
            private string body;
            private string fuel;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
