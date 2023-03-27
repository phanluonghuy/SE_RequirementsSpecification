using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Ticket
{
    public partial class Form2 : Form
    {
        static string s = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBoxDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection _cnn = new SqlConnection(s);
            //DataTable dt = new DataTable();
            //string query = "select cost from Destination where name = "+comboBoxDes.Text.ToString();
            //SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
           // MessageBox.Show(comboBoxDes.ValueMember.ToString());
            //_cnn.Open();
            //da.Fill(dt);
            //_cnn.Close();

            textBoxMoney.Text = comboBoxDes.SelectedValue.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection _cnn = new SqlConnection(s);
            DataTable dt = new DataTable();
            string query = "select * from Destination";
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();

            //var distinctValues = dt.AsEnumerable().Select(row => row["Name"]).Distinct();

            //comboBoxDes.Items.Clear();

            //foreach (var value in distinctValues)
            //{
            //    comboBoxDes.Items.Add(value.ToString());
            //}
            comboBoxDes.DataSource= dt;
            comboBoxDes.DisplayMember= "name";
            comboBoxDes.ValueMember= "cost";
            textBoxMoney.Text = "Please select destination";

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
