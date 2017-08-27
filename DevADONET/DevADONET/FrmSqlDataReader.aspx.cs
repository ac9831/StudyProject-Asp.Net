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
    public partial class FrmSqlDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"Select Num, Name, Email, Title, PostDate, PostIp
                                    From Memos
                                    Order By Num Desc";
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();

                string strOutput = "<table border=\"1\">" + "<tr><td>번호</td><td>이름</td><td>메모</td><td>작성일</td></tr>";
                while (dr.Read())
                {
                    strOutput += $"<tr><td>{dr["Num"]}</td>" + $"<td>{dr[1]}</td>" + $"<td>{dr.GetString(3)}</td>" +
                                 $"<td>{dr.GetDateTime(4).ToShortDateString()}</td></tr>";
                }
                strOutput += "</table>";
                dr.Close();
                tblOutput.Text = strOutput;
            }
            catch(SqlException sqlEx)
            {
                tblOutput.Text = sqlEx.ToString();
            }
            finally
            {
                
                con.Close();
            }
            
        }
    }
}