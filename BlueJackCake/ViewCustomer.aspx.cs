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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string memberEmail = GridView1.Rows[e.RowIndex].Cells[1].Text;

            Member m = DatabaseRepositories.findEmail(memberEmail);

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