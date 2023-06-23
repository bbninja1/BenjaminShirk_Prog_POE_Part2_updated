using BenjaminShirk_Prog_POE_Part2.Classes;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BenjaminShirk_Prog_POE_Part2
{
    public partial class AddFarmer : System.Web.UI.Page
    {
        //Refrences to Classes
        private DatabaseHandler _dbHandler = new DatabaseHandler();
        private Password Pass = new Password();

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonSaveClick
        /// <summary>
        /// save Farmer data to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSave_Click(object sender, EventArgs e)
        {
            //Validation for farmer inputs
            #region Validate Textboxes
            //checking textbox empty or null
            int farmerID = int.Parse(txtFarmerID.Text);
            if (!int.TryParse(txtFarmerID.Text, out farmerID))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Farmer ID";
                txtFarmerID.Text = string.Empty;
            }

            string firstName = txtFirstname.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid FirstName";
                txtFirstname.Text = string.Empty;

            }

            string surname = txtSurname.Text;
            if (string.IsNullOrEmpty(surname))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Surname";
                txtSurname.Text = string.Empty;
            }

            string email = txtEmail.Text;
            if (string.IsNullOrEmpty(email))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Email";
                txtEmail.Text = string.Empty;

            }

            string phoneNumber = txtPhoneNumber.Text;
            if (string.IsNullOrEmpty(phoneNumber))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid PhoneNumber";
                txtPhoneNumber.Text = string.Empty;

            }

            string address = txtAddress.Text;
            if (string.IsNullOrEmpty(address))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Address";
                txtAddress.Text = string.Empty;

            }

            string city = txtCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid City";
                txtCity.Text = string.Empty;

            }

            string Username = txtUsername.Text;
            if (string.IsNullOrEmpty(city))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Username";
                txtCity.Text = string.Empty;

            }
            string Password = txtPassword.Text;
            if (string.IsNullOrEmpty(city))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Invalid Password";
                txtCity.Text = string.Empty;

            }

            #endregion

            //Add into farmer table in database 
            #region AddToDatabase
            //ADD new Farmer
            TBLLogin Login = new TBLLogin();
            Login.Username = txtUsername.Text;
            string Hash = Pass.HashPassword(Password);
            Login.Hash = Hash;
            _dbHandler.AddLogin(Login);

            //Save Farmer in Database
            TBLFarmer farmer = new TBLFarmer();
            farmer.FarmerID = farmerID;
            farmer.Firstname = firstName;
            farmer.Surname = surname;   
            farmer.Email = email;   
            farmer.PhoneNumber = phoneNumber;
            farmer.Address = address;
            farmer.City_ = city;
            farmer.LoginID = _dbHandler.SaveLoginID(Login);

            _dbHandler.AddFarmer(farmer);

            Page.Response.Redirect("~/");
            #endregion

        }
        #endregion

    }
}
//------------------------------------------------------EndOFFile--------------------------------------------------------//