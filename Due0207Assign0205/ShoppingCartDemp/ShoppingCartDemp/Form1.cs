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

namespace ShoppingCartDemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string sql = "SELECT Id, FirstName,LastName, Email FROM dbo.customer WHERE FirstName Like '%" + firstName + "%'";
            string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";

 
            SqlConnection sqlConnection = new SqlConnection(connectionString) ;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter(sql, sqlConnection);
            DataSet customers = new DataSet();
            sqlDataAdaptor.Fill(customers, "Customers");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = customers.Tables[0];
            

        }
    }
}
