using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class ViewCustomer : System.Web.UI.Page
    {

        void loadData()
        {
            GridView1.DataSource = DatabaseRepositories.getAllMember();
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //biar tau dia row ke berapa
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell email = selectedRow.Cells[0];

                Member m = DatabaseRepositories.findEmail(email.Text.ToString());

                int row = DatabaseRepositories.deleteMember(m);
                if (row > 0)
                {
                    Response.Redirect("ViewCustomer.aspx");
                }
                else
                {
                    errorText.ForeColor = System.Drawing.Color.Red;
                    errorText.Text = "Delete Failed";
                }

            }
          
        }

    }
       
}