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
using System.Net;

namespace bsms
{
    public partial class staff : System.Web.UI.Page
    {

        //connection string variable
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        //name
        public List<string> name = new List<string>();
        //address
        public List<string> email = new List<string>();
        //date
        public List<string> birthday = new List<string>();
        //contact
        public List<string> roll = new List<string>();


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            getallnames();
            getallemail();
            getallbirthday();
            getallroll();
        }

        public void getallnames()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select name from TableRegester";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                name.Add((dr["name"]).ToString());
            }

        }

        public void getallemail()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select email from TableRegester";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                email.Add((dr["email"]).ToString());
            }

        }



        public void getallbirthday()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select birthday from TableRegester";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                birthday.Add((dr["birthday"]).ToString());
            }

        }

        public void getallroll()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select roll from TableRegester";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                roll.Add((dr["roll"]).ToString());
            }

        }
    }
}