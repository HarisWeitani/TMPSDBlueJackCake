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
            if (!Page.IsPostBack)
            {
                if (Session["user"] != null) Response.Redirect("Home.aspx");
                if (Request.Cookies["UserCookies"] != null)
                {
                    inputEmail.Text = Request.Cookies["UserCookies"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            Member member = DatabaseRepositories.LoginUser(inputEmail.Text, inputPassword.Text);

            txtError.Text = "";
            txtError.ForeColor = System.Drawing.Color.Red;


            if (member == null) txtError.Text = "User Not Found";
            else
            {
                if (isRemember.Checked)
                {
                    Response.Cookies["UserCookies"].Expires = DateTime.Now.AddHours(1);
                }
                else
                {
                    Response.Cookies["UserCookies"].Expires = DateTime.Now.AddHours(-1);
                }
                Response.Cookies["UserCookies"].Value = inputEmail.Text;
                
                Session["user"] = member;

                Response.Redirect("Home.aspx");
            }
        }

    }

}
