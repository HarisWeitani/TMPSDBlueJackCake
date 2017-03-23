using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            var query = String.Format(
                "INSERT INTO Member VALUES ({0},{1},{2},{3},{4},{5},{6}",
                inputEmail.Text,inputPassword.Text,inputName.Text,inputDOB.SelectedDate,inputPhoneNumber.Text,inputAddress.Text);

        }
    }
}