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
    public partial class FrmSqlCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSqlCommand_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"Insert Into Memos Values(N'홍길동', N'h@h.com', N'홍길동입니다.', GetDate(), '127.0.0.1')";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                lblDisplay.Text = "데이터 저장 완료";
            }
            catch(Exception exception)
            {
                lblDisplay.Text = exception.ToString();
            }
            finally
            {
                con.Close();
            }
            

            
        }
    }
}