using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public partial class ViewUsers : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select FirstName as 'First Name', LastName as 'Last Name', MobileNumber as 'Mobile#', Email from RegistrationTable", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        da.Fill(dt);

        gvUsers.DataSource = dt;
        gvUsers.DataBind();

    }

    protected void View_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}