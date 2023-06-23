using BenjaminShirk_Prog_POE_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BenjaminShirk_Prog_POE_Part2
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// private declerations 
        /// </summary>
        private DatabaseHandler _dbHandler = new DatabaseHandler();
        private Password Pass = new Password();

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonClick
        /// <summary>
        /// Insert Into database for Login with validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            #region InputData
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string Hash = "";
            #endregion

            #region AddLoginDetailsWithValidation
            //checks if user exists
            if (_dbHandler.DoesUserExist(Username) == true)
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "User alreadyExists";
            }

            //Checks if no data was entered
            else if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Data not entered";
            }
            //add data to database
            else
            {
                Hash = Pass.HashPassword(Password);
                TBLLogin login = new TBLLogin();
                login.Username = Username;
                login.Hash = Hash;
                _dbHandler.AddLogin(login);

                Page.Response.Redirect("~/Default");
                #endregion

            }
        }
        #endregion

    }
}
//------------------------------------------------------EndOFFile--------------------------------------------------------//