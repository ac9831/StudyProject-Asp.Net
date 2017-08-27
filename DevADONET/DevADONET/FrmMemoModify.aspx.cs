using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DevADONET.Models;

namespace DevADONET
{
    public partial class FrmMemoModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다.");
                Response.End();
            }
            else
            {
                if(!Page.IsPostBack)
                {
                    DisplayData();
                }
            }
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ViewMemo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("Num", SqlDbType.Int);
                cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    this.lblNum.Text = Request["Num"];
                    this.txtName.Text = dr["Name"].ToString();
                    this.txtEmail.Text = dr[2].ToString();
                    this.txtTitle.Text = dr.GetString(3);
                }
                else
                {
                    Response.Write("없는 데이터입니다.");
                    Response.End();
                }
            }
            catch(SqlException ex)
            {
                lblException.Text = ex.ToString();
            }
            finally
            {
                dr.Close();
                con.Close();
            }
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            Memo memo = new Memo();
            memo.Num = Convert.ToInt32(Request["Num"]);
            memo.Name = txtName.Text;
            memo.Email = txtEmail.Text;
            memo.Title = txtTitle.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ModifyMemo", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", memo.Name);
                cmd.Parameters.AddWithValue("@Email", memo.Email);
                cmd.Parameters.AddWithValue("@Title", memo.Title);
                cmd.Parameters.AddWithValue("@Num", memo.Num);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                lblException.Text = ex.ToString();       
            }
            finally
            {
                con.Close();
                Response.Redirect("FrmMemoView.aspx?Num=" + Request["Num"]);
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.RedirectPermanent("FrMemoList.aspx");
        }
    }
}