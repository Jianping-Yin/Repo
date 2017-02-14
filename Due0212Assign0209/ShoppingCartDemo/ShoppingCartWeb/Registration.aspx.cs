using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("usp_Customer_Insert", sqlConnection);
        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("FirstName", txtFirstName.Text);
        sqlCommand.Parameters.AddWithValue("LastName", txtLastName.Text);
        sqlCommand.Parameters.AddWithValue("Email", txtEmail.Text);
        sqlCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
        sqlCommand.Parameters.AddWithValue("UserName", txtUserName.Text);
        sqlCommand.Parameters.AddWithValue("Password", txtPassword.Text);

        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User registered...";

        sqlConnection.Close();
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("usp_Customer_GetById", sqlConnection);
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("Id", id);
        DataSet customers = new DataSet();
        sqlDataAdapter.Fill(customers, "Customers");
        DataTable dataTable = customers.Tables[0];
        if (dataTable.Rows.Count == 0)
        {
            lblInfo.Text = "No records";
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;

        }
        else
        {
            lblInfo.Text = String.Empty;
            txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
            txtEmail.Text = dataTable.Rows[0]["EMail"].ToString();
            txtPhone.Text = dataTable.Rows[0]["Phone"].ToString();
            txtUserName.Text = dataTable.Rows[0]["UserName"].ToString();
            txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
        }

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("usp_Customer_UpdateById", sqlConnection);
        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("Id", txtId.Text);
        sqlCommand.Parameters.AddWithValue("FirstName", txtFirstName.Text);
        sqlCommand.Parameters.AddWithValue("LastName", txtLastName.Text);
        sqlCommand.Parameters.AddWithValue("Email", txtEmail.Text);
        sqlCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
        sqlCommand.Parameters.AddWithValue("UserName", txtUserName.Text);
        sqlCommand.Parameters.AddWithValue("Password", txtPassword.Text);

        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User Updated...";

        sqlConnection.Close();


    }
}