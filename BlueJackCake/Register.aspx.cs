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
            if (Session["user"] != null) Response.Redirect("Home.aspx");
        }

        static bool checkEmail(string email)
        {
            if (email.Split('@').Length != 2) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") - 1) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") + 1) return false;
            return true;
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {

            string name = inputName.Text;
            string email = inputEmail.Text;
            string password = inputPassword.Text;
            string cPassword = confirmPassword.Text;
            string phone = inputPhoneNumber.Text;
            string address = inputAddress.Text;
            System.DateTime dob;

            Member member = DatabaseRepositories.findEmail(email);

            txtError.Text = "";
            txtError.ForeColor = System.Drawing.Color.Red;

            if (member == null)
            {
                if (!DateTime.TryParse(inputDOB.Text, out dob)) txtError.Text = "DOB is Wrong";
                else if (name == "") txtError.Text = "Name Must Not Empty";
                else if (email == "") txtError.Text = "Email Must Not Empty";
                else if (checkEmail(email) == false) txtError.Text = "Wrong Email Format";
                else if (password == "") txtError.Text = "Password Must Not Empty";
                else if (cPassword != password) txtError.Text = "Password Not Match";
                else if (phone == "") txtError.Text = "Phone Must Not Empty";
                else if (address == "") txtError.Text = "Address Must Not Empty";
                else
                {
                    Member m = UserFactory.create(email, password, name, dob, phone, address);

                    int row = DatabaseRepositories.register(m);
                    if (row > 0)
                    {
                        txtError.ForeColor = System.Drawing.Color.Blue;
                        txtError.Text = "Register Success";
                    }
                    else
                    {
                        txtError.Text = "Register Failed";
                    }
                }
            }
            else
            {
                txtError.Text = "Email Already Taken";
            }
        }
    }
}