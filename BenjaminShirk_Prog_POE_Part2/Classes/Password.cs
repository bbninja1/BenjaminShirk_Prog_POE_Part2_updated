using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace BenjaminShirk_Prog_POE_Part2.Classes
{
    /// <summary>
    /// Class used to save hashpassword method and Password exist method
    /// </summary>
    public class Password
    {
        private ST10081854DatabaseEntities Entity;

        #region HashPassword
        /// <summary>
        /// Hashing password
        /// </summary>
        /// <param name="StuPassword"></param>
        /// <returns></returns>
        public string HashPassword(string StuPassword)
        {
            SHA1CryptoServiceProvider HashPass = new SHA1CryptoServiceProvider();

            byte[] HashPassword = Encoding.ASCII.GetBytes(StuPassword);
            byte[] Hash = HashPass.ComputeHash(HashPassword);
            return Convert.ToBase64String(Hash);
        }
        #endregion

        #region PasswordExists
        /// <summary>
        /// Used to find if user exists
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool DoesPassExist(string Password)
        {
            HashPassword(Password);
            try
            {
                using (this.Entity = new ST10081854DatabaseEntities())
                {
                    TBLLogin FindHash = Entity.TBLLogins.FirstOrDefault(l => string.Compare(l.Hash, Password, true) == 0);

                    if (FindHash != null)
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

    }
}