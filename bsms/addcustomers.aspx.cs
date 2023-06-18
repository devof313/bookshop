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
    public partial class addcustomers : System.Web.UI.Page
    {

        //connection string variable
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        //name
        public List<string> name = new List<string>();
        //auther
        public List<string> address = new List<string>();
        //quantity
        public List<string> contact = new List<string>();
        //date
        public List<string> date = new List<string>();


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            void clearfn()
            {
                TextBox1.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label1.Text = "";

            }

            try
                {

                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into [customersTable](name, address, date, contact) values('" + TextBox1.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox3.Text + "' )", con);
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
                    Label1.Text = "Not uploaded" + ex.Message;

                }
            }

        protected void Button2_Click(object sender, EventArgs e)
        {
            void clearfn()
            {
                TextBox1.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label1.Text = "";

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            void clearfn()
            {
                TextBox1.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label1.Text = "";

            }

  
        }
    }

}