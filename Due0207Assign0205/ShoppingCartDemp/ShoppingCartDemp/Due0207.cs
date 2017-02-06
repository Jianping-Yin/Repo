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
    public partial class Due0207 : Form
    {
        public Due0207()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Id, FirstName,LastName, Email FROM dbo.customer";
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string smallInt = textBox3.Text;
            string bigInt = textBox4.Text;
            if (firstName != "" || lastName != "" || (smallInt != "" && bigInt != ""))
            {
                sql = sql + " WHERE ";
                if (firstName != "") sql = sql + "FirstName Like '%" + firstName + "%'" + " OR ";
                if (lastName != "") sql = sql + "LASTName Like '%" + lastName + "'" + " OR ";
                if (smallInt != "" && bigInt != "") sql = sql + "Id BETWEEN " + smallInt + " AND " + bigInt + " OR ";
                sql = sql.Substring(0, (sql.Length - 4));
            }

            #region change path when running on different computer
            string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";

            #endregion

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdaptor = new SqlDataAdapter(sql, sqlConnection);
            DataSet customers = new DataSet();
            sqlDataAdaptor.Fill(customers, "Customers");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = customers.Tables[0];
        }

    }
}
