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
    public partial class FrmMemoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다.");
                Response.End();
            }
            else
            {
                DisplayData();
                lnkMemoModify.NavigateUrl = $"FrmMemoModify.aspx?Num={Request["Num"]}";
                lnkMemoDelete.NavigateUrl = $"FrmMemoDelete.aspx?Num={Request["Num"]}";
            }
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ViewMemo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Num", SqlDbType.Int);
                cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    this.lblNum.Text = Request["Num"];
                    this.lblName.Text = dr["Name"].ToString();
                    this.lblEmail.Text = dr[2].ToString();
                    this.lblTitle.Text = dr.GetString(3);
                    this.lblPostData.Text = dr.GetDateTime(4).ToString();
                    this.lblPostIP.Text = dr.GetString(5);
                }
                else
                {
                    Response.Write("없는 데이터입니다.");
                    Response.End();
                }
                dr.Close();
            }
            catch(SqlException ex)
            {
                lblException.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
    }
}