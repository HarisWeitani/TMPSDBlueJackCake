using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class CakeUpdate : System.Web.UI.Page
    {
        Cake editCake;


        protected void Page_Load(object sender, EventArgs e)
        {

            string cakeName = Request.QueryString["cakeName"];

            if (cakeName != null)
            {
                editCake = DatabaseRepositories.findCake(cakeName);

                if (editCake != null) //check if cake exists
                {
                    if (!Page.IsPostBack)
                    {
                        inputCakeName.Text = editCake.CakeName;
                        inputPrice.Text = Convert.ToString(editCake.Price);
                        inputStock.Text = Convert.ToString(editCake.Stock);
                    }
                }
            }
        }

        protected void btnUpdateCake_Click(object sender, EventArgs e)
        {
            string picExt;
            string cakePic;

            //Cake cake = DatabaseRepositories.findCake(inputCakeName.Text);
            Cake cake = DatabaseRepositories.findCake(inputCakeName.Text);

            if (editCake == null) errorText.Text = "Cake Does Not Exist";
            else
            {
                if (inputCakeName.Text == "") errorText.Text = "Input Cake Name";
                else if (inputCakeName.Text != editCake.CakeName && cake != null) errorText.Text = "Cake Name Already Exist";
                else if (inputPrice.Text == "") errorText.Text = "Cake Price Must Not Empty";
                else if (inputStock.Text == "") errorText.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else if (Int32.Parse(inputStock.Text) <= 0) errorText.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else
                {
                    if (this.uploadPicture.HasFile)
                    {
                        //picExt = uploadPicture.FileName.Substring(uploadPicture.FileName.Length - 4);

                        picExt = System.IO.Path.GetExtension(uploadPicture.FileName).ToLower();

                        if (picExt == ".jpg" || picExt == ".png")
                        {
                            this.uploadPicture.SaveAs(Server.MapPath("~/") + inputCakeName.Text + picExt);
                            cakePic = inputCakeName.Text + picExt;

                            string cakeName = inputCakeName.Text;
                            int cakePrice = Int32.Parse(inputPrice.Text);
                            int cakeStock = Int32.Parse(inputStock.Text);

                            List<Cake> c = DatabaseRepositories.getAllCake(editCake.CakeName);
                            int row = DatabaseRepositories.updateCake(c, cakeName, cakePrice, cakeStock, cakePic);

                        }
                        else
                        {
                            errorText.Text = "Image Ekstension Must be .jpg or .png";
                        }
                    }
                    else
                    {
                        string cakeName = inputCakeName.Text;
                        int cakePrice = Int32.Parse(inputPrice.Text);
                        int cakeStock = Int32.Parse(inputStock.Text);
                        cakePic = null;

                        List<Cake> c = DatabaseRepositories.getAllCake(editCake.CakeName);
                        int row = DatabaseRepositories.updateCake(c, cakeName, cakePrice, cakeStock, cakePic);
                    }

                    Response.Redirect("Cake.aspx");
                }
            }


        }
    }
}