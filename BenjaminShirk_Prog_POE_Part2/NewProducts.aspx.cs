using BenjaminShirk_Prog_POE_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BenjaminShirk_Prog_POE_Part2
{
    public partial class NewProducts : System.Web.UI.Page
    {
        //decleration for database handler
        DatabaseHandler _dbHandler = new DatabaseHandler();

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonProductClick
        /// <summary>
        /// Add New Products Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AddProduct_Click(object sender, EventArgs e)
        {
            #region SaveDataInVariablesWithValidation

            //Validation of input collected

            int productID = int.Parse(txtProductID.Text);
            if (!int.TryParse(txtProductID.Text, out productID))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid ProductID";
                txtProductID.Text = string.Empty;
            }

            string productName = txtProductName.Text;
            if (string.IsNullOrEmpty(productName))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid ProductName";
                txtProductName.Text = string.Empty;
            }

            string productDescription = txtProductDescription.Text;
            if (string.IsNullOrEmpty(productDescription))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid productDescription";
                txtProductDescription.Text = string.Empty;

            }
            string dateAdded = txtDateAdded.Text;
            if (string.IsNullOrEmpty(dateAdded))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid DateAdded";
                txtDateAdded.Text = string.Empty;

            }
            string quantityAdded = (txtQuantityAdded.Text);
            if (string.IsNullOrEmpty(quantityAdded))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Quantity";
                txtQuantityAdded.Text = string.Empty;
            }
            #endregion

            #region SaveDataToDataBase
            //Save Data into database

            TBLProduct Product = new TBLProduct();
            TBLFarmer farmer = new TBLFarmer();
            int FarmerIDGetInt = farmer.FarmerID;
            Product.ProductID = productID;
            Product.ProductName = productName;
            Product.DateAdded = DateTime.Parse(dateAdded);
            Product.Quantity = quantityAdded;
            Product.FarmerID = _dbHandler.AddFarmerLoginID(farmer);
            Page.Response.Redirect("~/");
            #endregion

        }
        #endregion
    }
}
//------------------------------------------------------EndOFFile--------------------------------------------------------//