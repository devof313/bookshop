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
    public partial class customerlist : System.Web.UI.Page
    {

        //connection string variable
       public string connection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();


        //name
        public List<string> name = new List<string>();
        //address
        public List<string> address = new List<string>();
        //date
        public List<string> date = new List<string>();
        //contact
        public List<string> contact = new List<string>();


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookshop.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            getallnames();
            getalladdress();
            getalldate();
            getallcontact();
        }


        public void getallnames()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select name from customersTable";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                name.Add((dr["name"]).ToString());
            }

        }

        public void getalladdress()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select address from customersTable";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                address.Add((dr["address"]).ToString());
            }

        }



        public void getalldate()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select date from customersTable";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                date.Add((dr["date"]).ToString());
            }

        }

        public void getallcontact()
        {
            SqlConnection spcon = new SqlConnection(connection);
            spcon.Open();
            string command = "select contact from customersTable";
            SqlCommand cmdd = new SqlCommand(command, spcon);
            SqlDataReader dr;
            dr = cmdd.ExecuteReader();
            //storing all values of nme column in name variable
            while (dr.Read())
            {
                contact.Add((dr["contact"]).ToString());
            }

        }
    }



}