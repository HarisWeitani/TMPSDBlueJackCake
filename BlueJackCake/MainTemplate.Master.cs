using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class MainTemplate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["user"];
            if (currentUser != null)
            {
                userName.Text = currentUser.Name;
                userType.Text = currentUser.Type;
            }
            currentDateTime.Text = DateTime.Now.ToString();
        }

    }
}