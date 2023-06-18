using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data;

namespace bsms
{
    public partial class attendance : System.Web.UI.Page
    {


        //connection string variable
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        //name
        public List<string> name = new List<string>();
        //auther
        public List<string> author = new List<string>();
        //quantity

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (RadioButton1.Checked)
            {

                try
                {

                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into [AttendanceTable](Name, Attended) values('" + TextBox1.Text + "', '" + RadioButton1.Text + "' )", con);
                        int t = cmd.ExecuteNonQuery();
                        if (t > 0)
                        {
                            Response.Write("<script>alert('Saved Successfully !! ')</script>");
                            clearfn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "No employy with this name" + ex.Message;

                }
            }
            else
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into [AttendanceTable](Name, Attended) values('" + TextBox1.Text + "', '" + RadioButton2.Text + "' )", con);
                        int t = cmd.ExecuteNonQuery();
                        if (t > 0)
                        {
                            Response.Write("<script>alert('Saved Successfully !! ')</script>");
                            clearfn();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "No employy with this name" + ex.Message;

                }
            }
        }

        public void clearfn()
        {
            TextBox1.Text = "";
            Label1.Text = "";

        }
    }
}