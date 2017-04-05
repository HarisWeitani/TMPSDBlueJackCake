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
        void loadDataAdmin()
        {
            GridView1.DataSource = DatabaseRepositories.getAllCake();
            GridView1.DataBind();
        }

        void loadDataCustomer()
        {
            GridView2.DataSource = DatabaseRepositories.getAllCake();
            GridView2.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Member currentUser = (Member)Session["user"];

            if(currentUser == null ){
                btnAddCake.Visible = false;
                loadDataCustomer();
            }
            else if (currentUser.Type == "Admin")
            {
                btnAddCake.Visible = true;
                loadDataAdmin();
            }
            else if(currentUser.Type == "Customer")
            {
                btnAddCake.Visible = false;
                loadDataCustomer();
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

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            Response.Redirect("CakeAdd.aspx");
        }
    }
}