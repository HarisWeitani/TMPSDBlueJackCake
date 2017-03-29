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
            if (currentUser == null)
            {
                guestPagesState(true);
            }
            else if (currentUser != null)
            {
                userName.Text = currentUser.Name;
                if (currentUser.Type == "Admin")
                {
                    adminPagesState(true);
                }
                else if(currentUser.Type == "Customer")
                {
                    customerPagesState(true);
                }

                //userType.Text = currentUser.Type;
            }
            currentDateTime.Text = DateTime.Now.ToString();
        }

        public void guestPagesState(bool state)
        {
            hlHome.Visible = state;
            hlLogin.Visible = state;
            hlRegister.Visible = state;
            hlForgotPassword.Visible = state;
            hlCake.Visible = state;

            hlAddCake.Visible = !state;
            hlUpdateCake.Visible = !state;
            hlViewCustomer.Visible = !state;
            hlLogOut.Visible = !state;
        }

        public void adminPagesState(bool state)
        {
            hlHome.Visible = state;
            hlCake.Visible = state;
            hlAddCake.Visible = state;
            hlUpdateCake.Visible = state;
            hlViewCustomer.Visible = state;
            hlLogOut.Visible = state;

            hlLogin.Visible = !state;
            hlRegister.Visible = !state;
            hlForgotPassword.Visible = !state;
        }

        public void customerPagesState(bool state)
        {
            hlHome.Visible = state;
            hlCake.Visible = state;
            hlLogOut.Visible = state;

            hlLogin.Visible = !state;
            hlAddCake.Visible = !state;
            hlUpdateCake.Visible = !state;
            hlViewCustomer.Visible = !state;
            hlRegister.Visible = !state;
            hlForgotPassword.Visible = !state;
        }



    }
}