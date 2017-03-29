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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdateCake_Click(object sender, EventArgs e)
        {
            string picExt;
            string cakePic;

            Cake cake = DatabaseRepositories.findCake(inputCakeName.Text);

            if (cake == null) errorText.Text = "Cake Does Not Exist";
            else
            {
                if (inputCakeName.Text == "") errorText.Text = "Input Cake Name";
                else if (inputPrice.Text == "") errorText.Text = "Cake Price Must Not Empty";
                else if (inputStock.Text == "") errorText.Text = "Cake Stock Must Not Empty & Greater Than 0";
                else
                {
                    if (this.uploadPicture.HasFile)
                    {
                        picExt = uploadPicture.FileName.Substring(uploadPicture.FileName.Length - 4);
                        if (picExt == ".jpg" || picExt == ".png")
                        {
                            this.uploadPicture.SaveAs(Server.MapPath("~/") + inputCakeName.Text + picExt);
                            cakePic = inputCakeName.Text + picExt;

                            string cakeName = inputCakeName.Text;
                            int cakePrice = Int32.Parse(inputPrice.Text);
                            int cakeStock = Int32.Parse(inputStock.Text);

                            List<Cake> c = DatabaseRepositories.getAllCake(cakeName);
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

                        List<Cake> c = DatabaseRepositories.getAllCake(cakeName);
                        int row = DatabaseRepositories.updateCake(c, cakeName, cakePrice, cakeStock, cakePic);
                    }

                }
            }


        }
    }
}