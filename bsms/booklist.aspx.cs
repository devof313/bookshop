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
using System.Web.Services.Description;
using System.Reflection.Emit;

namespace bsms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //connection string variable
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        //name
        public List<string> name = new List<string>();
        //auther
        public List<string> author = new List<string>();
        //cover
        public List<string> imgg = new List<string>();
        //search
        public List <string> search = new List<string>();

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");

          
                public void getallnames()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select name from bookTable";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                name.Add((dr["name"]).ToString());
            }

        }
    

    public void getallauthor()
    {
        SqlConnection spcon = new SqlConnection(connection);
        spcon.Open();
        string command = "select author from bookTable";
        SqlCommand cmdd = new SqlCommand(command, spcon);
        SqlDataReader dr;
        dr = cmdd.ExecuteReader();
        //storing all values of nme column in name variable
        while (dr.Read())
        {
            author.Add((dr["author"]).ToString());
        }

    }
    public void getallcovers()
    {
        SqlConnection spcon = new SqlConnection(connection);
        spcon.Open();
        string command = "select imgg from bookTable";

            SqlCommand cmdd = new SqlCommand(command, spcon);
        SqlDataReader dr;
        dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable


            while (dr.Read())
        {
            imgg.Add((dr["imgg"]).ToString());

        }

    }
        public void searchbook()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select * from bookTable";

            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable


            while (dr.Read())
            {
                search.Add((dr["*"]).ToString());

            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {



            getallnames();
            getallauthor();
            getallcovers();

    }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlConnection con = sqlConnection;
           
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string sqlquery = "select * from bookTable where name like '%'+@name+'%'";
            cmd.CommandText = sqlquery;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("name", TextBox1.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
          

        }
    }
}