using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace bsms
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string ins = "insert into [TableRegester](name, username, email, roll, passcode, birthday) values('" + TextBox.Text + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox4.Text + "', '" + TextBox3.Text + "', '" + TextBox5.Text + "')";
         SqlCommand com = new SqlCommand(ins,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Successfully Registered !! ')</script>");
        }
    }
}