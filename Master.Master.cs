using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Municipal
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        protected void btnClick(object sender, EventArgs e)
        {
            if (labelpassword.Visible == false)
            {
                labeluser.Visible = true;
                labelpassword.Visible = true;
                password.Visible = true;
                username.Visible = true;
                btnlogin.Visible = true;
            }
            else
            {
                labeluser.Visible = false;
                labelpassword.Visible =false;
                password.Visible = false;
                username.Visible = false;
                btnlogin.Visible = false;
            }
        }

        protected void loginClick(object sender, EventArgs e)
        {
            string usr = username.Text;
            string pass = password.Text;
            if (usr == "mayor" && pass == "123")
            {
                Response.Redirect("~/Home/Home");

            }
        }
    }
}