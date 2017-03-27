using BlueJackCake.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BlueJackCake
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null) Response.Redirect("Home.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Member member = DatabaseRepositories.LoginUser(inputEmail.Text, inputPassword.Text);

            if (member == null) Response.Write("Not Found");
            else
            {
                Session["user"] = member;
                
                Response.Redirect("Home.aspx");
            }
        }

    }

}
