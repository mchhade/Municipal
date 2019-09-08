using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Municipal
{
    public partial class CV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                SqlConnection sqlConnection = new
                SqlConnection("Data Source=DESKTOP-N7T3C57;Initial Catalog=Municipal;Integrated Security=True");
                sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select* from personnel", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                name.Text = sqlDataReader["name_personnel"].ToString();
                bdates.Text = sqlDataReader["BirthDate"].ToString();
                address.Text = sqlDataReader["Address_personnel"].ToString();
                father.Text = sqlDataReader["father"].ToString();
                mother.Text = sqlDataReader["mother"].ToString();
                kids.Text = sqlDataReader["kids"].ToString();
                status.Text = sqlDataReader["maritalStatus"].ToString();
            }
          
        }

        }

     
    }
