using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void inputResetPassword_Click(object sender, EventArgs e)
        {
            Member member = DatabaseRepositories.ForgotPassword(inputemail.Text);

            txtError.Text = "";
            txtError.ForeColor = System.Drawing.Color.Red;

            if (member == null) txtError.Text = "Email Not Found";
            else
            {
                Response.Write("mantab");
            }

        }
    }
}