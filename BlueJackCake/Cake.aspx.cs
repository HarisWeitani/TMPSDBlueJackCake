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
            
            if (e.CommandName == "Update")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell cakeName = selectedRow.Cells[0];

                Cake c = DatabaseRepositories.findCake(cakeName.Text.ToString());

                if (c != null)
                {
                    Response.Redirect("CakeUpdate.aspx");
                }
                else
                {
                    errorText.ForeColor = System.Drawing.Color.Red;
                    errorText.Text = "Update Failed";

                }

            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string cakeName = GridView1.Rows[e.RowIndex].Cells[0].Text;

            Cake c = DatabaseRepositories.findCake(cakeName);

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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string cakeName = GridView1.Rows[e.RowIndex].Cells[0].Text;

            Response.Redirect(string.Format("CakeUpdate.aspx?cakeName={0}", cakeName));

        }
    }
}