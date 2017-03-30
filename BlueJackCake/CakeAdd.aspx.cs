using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlueJackCake
{
    public partial class CakeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCake_Click(object sender, EventArgs e)
        {
            string picExt;
            string cakePic;

            Cake cake = DatabaseRepositories.findCake(inputCakeName.Text);

            if (cake == null)
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

                            Cake c = CakeFactory.create(cakeName, cakePrice, cakeStock, cakePic);
                            int row = DatabaseRepositories.addCake(c);

                            if (row > 0)
                            {
                                errorText.ForeColor = System.Drawing.Color.Blue;
                                errorText.Text = "Add Cake Success";
                            }
                            else
                            {
                                errorText.Text = "Add Cake Failed";
                            }
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

                        Cake c = CakeFactory.create(cakeName, cakePrice, cakeStock, cakePic);
                        int row = DatabaseRepositories.addCake(c);

                        if (row > 0)
                        {
                            errorText.ForeColor = System.Drawing.Color.Blue;
                            errorText.Text = "Add Cake Success, No Picture Added";
                        }
                        else
                        {
                            errorText.Text = "Add Cake Failed";
                        }
                    }

                }
            }
            else
            {
                errorText.Text = "Cake Name Already Exist";
            }

        }
    }
}