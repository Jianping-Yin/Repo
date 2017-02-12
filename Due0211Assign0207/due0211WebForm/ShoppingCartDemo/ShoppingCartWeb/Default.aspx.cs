using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text); //Int32.Parse
        String sql = "SELECT Id, FirstName, LastName, UserName, Password, IsActive, Email, CreatedDate FROM dbo.Customer WHERE Id = " + id;

        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        sqlConnection.Open();

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);

        DataSet customers = new DataSet();

        sqlDataAdapter.Fill(customers, "Customers");
        DataTable dataTable = customers.Tables[0];
        if (dataTable.Rows.Count == 0)
        {
            lblInfo.Text = "Cannot find this user profile";
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtIsActive.Text = String.Empty;
            lblUserName.Text = String.Empty;
            lblCreatedDate.Text = String.Empty;
        }
        else
        {
            lblInfo.Text = String.Empty;//""

            txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
            txtEmail.Text = dataTable.Rows[0]["EMail"].ToString();
            txtPassword.Text = dataTable.Rows[0]["Password"].ToString();
            txtIsActive.Text = dataTable.Rows[0]["IsActive"].ToString();
            lblUserName.Text = dataTable.Rows[0]["UserName"].ToString();
            lblCreatedDate.Text = dataTable.Rows[0]["CreatedDate"].ToString();
        }

        sqlConnection.Close();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        String sql = "UPDATE dbo.Customer " +
            " SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Email = '" + txtEmail.Text + "', Password = '" + txtPassword.Text + "', IsActive = '" + txtIsActive.Text +
            "' WHERE Id = " + txtId.Text;

        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User Profiler updated...";
        sqlConnection.Close();        
    }
    //    Extend our demo website to make Email, Password, IsActive updatable, Display read only userName, CreatedDate

    //Add a Delete button next to Update button to delete this user, and also display "user profiler deleted" upon success

 
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        String sql = "DELETE FROM dbo.Customer WHERE Id = " + txtId.Text;

        string connectionString = @"Data Source=LAPTOP-TOJJ8FAA\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=DemoShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User Profiler deleted...";
        txtFirstName.Text = String.Empty;
        txtLastName.Text = String.Empty;
        txtEmail.Text = String.Empty;
        txtPassword.Text = String.Empty;
        txtIsActive.Text = String.Empty;
        lblUserName.Text = String.Empty;
        lblCreatedDate.Text = String.Empty;


        sqlConnection.Close();

    }
}