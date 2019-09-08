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
    public partial class Publisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 100; i++)
                    Number.Items.Add(i.ToString());
                type.Items.Add("Economic");
                type.Items.Add("Comercial");
                type.Items.Add("Social");
            }
        }

      

        protected void submit_Click(object sender, EventArgs e)
        {
            try {
                
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-N7T3C57;Initial Catalog=Municipal;Integrated Security=True");
                sqlConnection.Open();
                string query = "insert into publisher(first_name,last_name,from_date,to_dates,number,type_pub,limit,street) values (@first_name,@last_name,@from_date,@to_dates,@number,@type_pub,@limit,@street)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@first_name",firstname.Text);
                sqlCommand.Parameters.AddWithValue("@last_name", lastname.Text);
                if (Limited.Checked)
                {
                    sqlCommand.Parameters.AddWithValue("@limit", "yes");
                    sqlCommand.Parameters.AddWithValue("@from_date", from.Text);
                    sqlCommand.Parameters.AddWithValue("@to_dates", to.Text);
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@limit", "no");
                    sqlCommand.Parameters.AddWithValue("@from_date", DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@to_dates", DBNull.Value);
                }
                sqlCommand.Parameters.AddWithValue("@number",Number.SelectedItem.Text);
                sqlCommand.Parameters.AddWithValue("@type_pub",type.SelectedItem.Text);
                sqlCommand.Parameters.AddWithValue("@street", place.Text);
                sqlCommand.ExecuteNonQuery();
               }

            catch (Exception ex)
            {
                MsgBox(ex.ToString(),this.Page,this);
            }
           // MsgBox("add succufully", this.Page, this);
            

        }

        private void MsgBox(string v, Page page, Publisher publisher)
        {
            string s = "<SCRIPT language='javascript'>alert('" + v.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = publisher.GetType();
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
        
    }
}