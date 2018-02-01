using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Users\\ashwinp\\Desktop\\College Website\\App_Data\\tbl_feedback.mdf\";Integrated Security=True;User Instance=True");
        conn.Open();
        SqlCommand cmd=new SqlCommand("insert into tbl_feedback values('"+TextBox1.Text.ToString()+"','"+TextBox2.Text.ToString()+"','"+TextBox3.Text.ToString()+"')",conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("~/Home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}