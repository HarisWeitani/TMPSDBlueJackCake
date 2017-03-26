using BlueJackCake.Helpers;
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
        String DOB;

        DatabaseHelper con;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new DatabaseHelper();
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            DOB = DateTime.Parse(userDOB.Text).ToString("yyyy-MM-dd");

            //tutorial sql C#
            String query = "INSERT INTO Member(Email,Password,Name,DOB,PhoneNumber,Address) VALUES('"+inputEmail.Text+"' , '"+inputPassword.Text+ "' , '"+inputName.Text+ "' , '"+DOB+ "' , '"+inputPhoneNumber.Text+ "' , '"+inputAddress.Text+"' ) ";

            con.ExecuteUpdate(query);

            Response.Write("Register Success");

        }
    }
}