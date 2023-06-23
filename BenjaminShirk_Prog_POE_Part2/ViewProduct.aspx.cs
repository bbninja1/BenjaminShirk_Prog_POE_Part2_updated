using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


namespace BenjaminShirk_Prog_POE_Part2
{
    public partial class ViewProduct : System.Web.UI.Page
    {
       
        /// <summary>
        /// SQL Connection
        /// </summary>
        public SqlConnection Connection;

        //sql connection string 
        string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=[Directory]\\App_Data\\ST10081854Database.mdf;Integrated Security=True;Multiple Active Result Sets=True;Application Name=EntityFramework";

        #region PageLoad
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region DatabaseViewButton
        /// <summary>
        /// View Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnView_Click(object sender, EventArgs e)
        {
            //connnect method and view product table data
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                string query = "SELECT * FROM TBLProducts";
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable TBL = new DataTable();
                    adapter.Fill(TBL);
                    GridView1.DataSource = TBL;
                    GridView1.DataBind();
                }
            }
        }
        #endregion

        #region SortDateButton
        /// <summary>
        /// Sort by Date query DESC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Connection.Open();
                string query = "SELECT * FROM TBLProducts ORDER BY DateAdded DESC ";
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable TBL = new DataTable();
                    adapter.Fill(TBL);
                    GridView1.DataSource = TBL;
                    GridView1.DataBind();
                }
            }
        }
        #endregion

        #region ButtonBack
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/");
        }
        #endregion

    }

}
//------------------------------------------------------EndOFFile--------------------------------------------------------//