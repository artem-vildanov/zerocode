using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        car TAZ;

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb;";
        private OleDbConnection myConnection;

        
        public Form1()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_but_Click(object sender, EventArgs e)
        {

        }

        private void output_res_but_Click(object sender, EventArgs e)
        {
            TAZ.minPrice = Convert.ToInt32(min_text_box.Text);
            TAZ.maxPrice = Convert.ToInt32(max_text_box.Text);


            string query = "SELECT * FROM CAR WHERE Price between @minPrice and @maxPrice";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.Parameters.AddWithValue("@minPrice", TAZ.minPrice);
            command.Parameters.AddWithValue("@maxPrice", TAZ.maxPrice);
            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // выполняем запрос и выводим результат в textBox1
            while(reader.Read())
                Console.WriteLine(reader[1] + " " + reader[2]);
        }

        private void accept_price_button_Click(object sender, EventArgs e)
        {
            

            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }
    }
}
