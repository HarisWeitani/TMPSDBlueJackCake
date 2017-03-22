
using BlueJackCake.Helpers;
using System;
using System.Collections.Generic;
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
            if (Session["userLogin"] != null)
            {
                Response.Redirect("Home.aspx");
            }

            if (Request.Cookies["Username"] != null)
            {
                inputEmail.Text = Request.Cookies["Username"].Value;
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var query = String.Format(
                "SELECT * FROM Member WHERE Email='{0}' AND Password='{1}'",
                inputEmail.Text, inputPassword.Text);

            var dbHelper = new DatabaseHelper();
            var result = dbHelper.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                var userLoginList = new List<String>();
                if (Application["userLoginList"] != null)
                {
                    userLoginList = Application["userLoginList"] as List<String>;
                }
                userLoginList.Add(inputEmail.Text);

                Application["userLoginList"] = userLoginList;

                Session["userLogin"] = inputEmail.Text;

                Response.Redirect("Home.aspx");

            }
            else
            {
                errorMessage.Text = "User not Found!";
            }

        }
    }
}