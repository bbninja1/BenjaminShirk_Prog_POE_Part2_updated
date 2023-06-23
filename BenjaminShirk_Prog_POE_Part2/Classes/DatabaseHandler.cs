using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Profile;


namespace BenjaminShirk_Prog_POE_Part2.Classes
{

    //Database handling Class
    public class DatabaseHandler
    {
        private ST10081854DatabaseEntities Entity;
        /// <summary>
        ///     SQL DB Connection String
        /// </summary>
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ST10081854DatabaseEntities"].ConnectionString;

        /// <summary>
        ///     SQL Command
        /// </summary>
        private SqlCommand Command;

        /// <summary>
        ///     SQL Connection
        /// </summary>
        private SqlConnection Connection;

        #region AddFarmerLoginID
        /// <summary>
        /// Add Farmer LoginID
        /// </summary>
        /// <param name="newFarmer"></param>
        /// <returns></returns>
        public int AddFarmerLoginID(TBLFarmer newFarmer)
        {
            try
            {
                using (var context = new ST10081854DatabaseEntities())
                {
                    context.TBLFarmers.Add(newFarmer);
                    context.SaveChanges();

                    var LoginID = newFarmer.LoginID;
                    return LoginID;
                    
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        #endregion

        #region AddFarmer
        /// <summary>
        /// Add farmer 
        /// </summary>
        /// <param name="newFarmer"></param>
        /// <returns></returns>
        public bool AddFarmer(TBLFarmer newFarmer)
        {
            try
            {
                using (var context = new ST10081854DatabaseEntities())
                {
                    context.TBLFarmers.Add(newFarmer);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        #endregion

        #region UsernameExists
        /// <summary>
        /// Used to find if user exists
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public bool DoesUserExist(string Username)
        {
            try
            {
                using (this.Entity = new ST10081854DatabaseEntities())
                {
                    TBLLogin FindLogin = Entity.TBLLogins.FirstOrDefault(l => string.Compare(l.Username, Username, true) == 0);

                    if (FindLogin != null)
                    {
                        return true;
                    }
                    return false;
     
                }
            }
            catch (Exception e)
            {
                return true;
            }

        }
        #endregion;

        #region AddLogin
        /// <summary>
        /// Add Login
        /// </summary>
        /// <param name="newLogin"></param>
        /// <returns></returns>
        public bool AddLogin(TBLLogin newLogin)
        {
            try
            {
                using (var context = new ST10081854DatabaseEntities())
                {
                    context.TBLLogins.Add(newLogin);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        #endregion

        #region AddProduct
        /// <summary>
        /// Add farmer 
        /// </summary>
        /// <param name="AddProduct"></param>
        /// <returns></returns>
        public bool AddProduct(TBLProduct newProduct)
        {
            try
            {
                using (var context = new ST10081854DatabaseEntities())
                {
                    context.TBLProducts.Add(newProduct);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }

        #endregion

        #region LoginID
        /// <summary>
        /// Create/SaveLoginID
        /// </summary>
        /// <param name="LoginID"></param>
        /// <returns></returns>
        public int SaveLoginID(TBLLogin LoginID)
        {
            try
            {
                using (var context = new ST10081854DatabaseEntities())
                {
                    context.TBLLogins.Add(LoginID);
                    context.SaveChanges();

                    var newUserLoginID = LoginID.LoginID;
                    return newUserLoginID;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        #endregion
    }

}
//------------------------------------------------------EndOFFile--------------------------------------------------------