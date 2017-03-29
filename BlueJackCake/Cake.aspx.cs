using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class Cake : System.Web.UI.Page
    {
        void loadData()
        {
            GridView1.DataSource = DatabaseRepositories.getAllCake();
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Delete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell cakeName = selectedRow.Cells[0];

                Cake c = DatabaseRepositories.findCake(cakeName.Text.ToString());

                int row = DatabaseRepositories.deleteCake(c);
                if (row > 0)
                {
                    Response.Redirect("Cake.aspx");
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