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
            Member member = DatabaseRepositories.findEmail(inputemail.Text);

            txtError.Text = "";
            txtError.ForeColor = System.Drawing.Color.Red;

            if (member == null) txtError.Text = "Email Not Found";
            else
            {
                string name = member.Name;
                string newPassword;

                const string alphabet = "abcdefghijklmnopqrstuvwxyz";

                Random rand = new Random((int)DateTime.Now.Ticks);

                string number1 = rand.Next(0, 9).ToString();
                string number2 = rand.Next(0, 9).ToString();
                string char1 = alphabet.Substring(rand.Next(0, alphabet.Length - 1), 1);
                string char2 = alphabet.Substring(rand.Next(0, alphabet.Length - 1), 1);
                string cutName = name.Substring(0, 2);

                newPassword = number1 + number2 + char1 + char2 +cutName;

                txtError.ForeColor = System.Drawing.Color.Green;
                txtError.Text = "Your New Password : "+newPassword;

                List<Member> m = DatabaseRepositories.getAllMember(inputemail.Text);
                int row = DatabaseRepositories.updateMember(m, newPassword);

            }

        }
    }
}