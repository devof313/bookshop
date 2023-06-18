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


    public partial class addbooks : System.Web.UI.Page
    {
       
        //connection string variable
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                clearfn();
            }

        }

      


        protected void Button1_Click(object sender, EventArgs e)
        {



            if (imgg.HasFiles)
            {
                try
                {
                    string fname=Path.GetFileName(imgg.FileName);
                    imgg.SaveAs(Server.MapPath("images/dataimg/") + fname);
                    String link = "images/dataimg/" + fname;
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into [bookTable](name, author, quantity, price, dateadded, imgg, category) values('" + TextBox1.Text + "', '" + TextBox4.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "','" + TextBox5.Text + "', '" + link + "', '" + TextBox6.Text + "' )", con);
                        int t = cmd.ExecuteNonQuery();
                        if(t > 0)
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

     
       }

        public void clearfn()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            Label1.Text = "";
    
       }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}