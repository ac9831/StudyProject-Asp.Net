using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
    public partial class FrmSqlDataAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"Select Num, Name, Email, Title, PostDate, PostIp 
                                    From Memos Order By Num Desc";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds, "Memos");

                ctlMemoLists.DataSource = ds.Tables[0].DefaultView;
                ctlMemoLists.DataBind();
            }
            catch(SqlException sqlEx)
            {
                lblException.Text = sqlEx.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}