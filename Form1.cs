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
    public partial class car_choose : Form
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


        public car_choose()
        {
            InitializeComponent();

            // создаем экземпляр класса OleDbConnection
            myConnection = new OleDbConnection(connectString);

            // открываем соединение с БД
            myConnection.Open();

            TAZ.GB = string.Empty;
            TAZ.rul = string.Empty;
            TAZ.privod = string.Empty;
            TAZ.obyem = -1;
            TAZ.body = string.Empty;
            TAZ.fuel = string.Empty;

        }

        private void output_res_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = true;




            //try
            //{
                TAZ.minPrice = Convert.ToInt32(min_text_box.Text);
                TAZ.maxPrice = Convert.ToInt32(max_text_box.Text);

                if (radioButton_kuziv_hetchback.Checked) TAZ.body = "Хэтчбек";
                if (radioButton_kuzov_jeep.Checked) TAZ.body = "Джип";
                if (radioButton_kuzov_minivan.Checked) TAZ.body = "Минивэн";
                if (radioButton_kuzov_pickup.Checked) TAZ.body = "Пикап";
                if (radioButton_kuzov_sedan.Checked) TAZ.body = "Седан";




                string query =
                    "SELECT Mark, Model, Price " +
                    "FROM CAR " +
                    "WHERE " +
                    "(Price BETWEEN @minPrice AND @maxPrice) ";
                //+
                //"AND GB = @GB " + "AND Rul = @rul " + "AND Privod = @privod " + "AND Obyem = @obyem " +
                //"AND Body_Type = @body " + "AND Fuel = @fuel";

                if (!string.IsNullOrEmpty(TAZ.GB))
                    query += "AND GB = @GB ";

                if (!string.IsNullOrEmpty(TAZ.rul))
                    query += "AND Rul = @rul ";

                if (!string.IsNullOrEmpty(TAZ.privod))
                    query += "AND Privod = @privod ";

                if (!string.IsNullOrEmpty(TAZ.rul))
                    query += "AND Rul = @rul ";
                
                if (TAZ.obyem != -1)
                    query += "AND Obyem = @obyem ";

                if (!string.IsNullOrEmpty(TAZ.body))
                    query += "AND Body_Type = @body ";

                if (!string.IsNullOrEmpty(TAZ.fuel))
                    query += "AND Fuel = @fuel ";


               // OleDbCommand czxc = new OleDbCommand()
                OleDbCommand command = new OleDbCommand(query, myConnection);
                
                command.Parameters.AddWithValue("@minPrice", TAZ.minPrice);
                command.Parameters.AddWithValue("@maxPrice", TAZ.maxPrice);
                command.Parameters.AddWithValue("@GB", TAZ.GB);
                command.Parameters.AddWithValue("@rul", TAZ.rul);
                command.Parameters.AddWithValue("@privod", TAZ.privod);
                command.Parameters.AddWithValue("@obyem", TAZ.obyem);
                command.Parameters.AddWithValue("@body", TAZ.body);
                command.Parameters.AddWithValue("@fuel", TAZ.fuel);

                // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
                OleDbDataReader reader = command.ExecuteReader();

                // выполняем запрос и выводим результат в textBox1
                richTextBox1.Text = "";
                richTextBox1.Text += "МАРКА МОДЕЛЬ\tЦЕНА\n";
                while (reader.Read())
                {
                    
                    richTextBox1.Text += reader[0] + " " + reader[1] + "\t\t\t" + reader[2] + " руб.\n";
                }
                    

            //}

            //catch
            //{
            //    MessageBox.Show("Неверный ввод данных");
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // заркываем соединение с БД
            myConnection.Close();
        }

        private void price_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = true;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }


        private void kpp_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = true;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }

        private void rul_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = true;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }

        private void privod_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = true;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }

        private void obyom_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = true;
            panel_kuzov.Visible = false;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }

        private void kuzov_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = true;
            panel_engine.Visible = false;
            panel_output_res.Visible = false;
        }

        private void engine_but_Click(object sender, EventArgs e)
        {
            panel_price.Visible = false;
            panel_kpp.Visible = false;
            panel_rul.Visible = false;
            panel_privod.Visible = false;
            panel_obyom.Visible = false;
            panel_kuzov.Visible = false;
            panel_engine.Visible = true;
            panel_output_res.Visible = false;
        }

        private void trackBar_obyom_switch_Scroll(object sender, EventArgs e)
        {
            textBox_obyom_switch.Text = Convert.ToString(Convert.ToDouble(trackBar_obyom_switch.Value) / 10);
            TAZ.obyem = Convert.ToDouble(trackBar_obyom_switch.Value) / 10;
        }

        private void textBox_obyom_switch_TextChanged(object sender, EventArgs e)
        {
            //trackBar_obyom_switch.Value = Convert.ToInt32(Convert.ToDouble(textBox_obyom_switch.Text)*10);
        }

        //private void radioButton_kuzov_sedan_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton_kuziv_hetchback_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton_kuzov_pickup_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void radioButton_kuzov_minivan_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void button_engine_electro_Click(object sender, EventArgs e)
        {
            TAZ.fuel = "Электро";
        }

        private void button_engine_petrol_Click(object sender, EventArgs e)
        {
            TAZ.fuel = "Бензин";
        }

        private void button_engine_disel_Click(object sender, EventArgs e)
        {
            TAZ.fuel = "Дизель";
        }

        private void button_begin_Click(object sender, EventArgs e)
        {
            panel_startpage.Visible = false;
        }

        private void button_kpp_m_Click(object sender, EventArgs e)
        {
            TAZ.GB = "Механика";
        }

        private void button_kpp_a_Click(object sender, EventArgs e)
        {
            TAZ.GB = "Автомат";
        }

        private void button_fwd_Click(object sender, EventArgs e)
        {
            TAZ.privod = "FWD";
        }

        private void button_rwd_Click(object sender, EventArgs e)
        {
            TAZ.privod = "RWD";
        }

        private void button_4wd_Click(object sender, EventArgs e)
        {
            TAZ.privod = "4WD";
        }

        private void button_left_rul_Click(object sender, EventArgs e)
        {
            TAZ.rul = "Левый";
        }

        private void button_right_rul_Click(object sender, EventArgs e)
        {
            TAZ.rul = "Правый";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
